using System.Configuration;
using System.Security.Cryptography;
using MySqlConnector;

namespace WinFormsApp1.DAL;

internal static class UserAuth
{
    private const int Iterations = 600000;
    private static MySqlConnection CreateConnection() => new(
        ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString
        ?? throw new InvalidOperationException("MyDbConnection is missing from App.config."));

    internal static async Task<bool> RegisterAsync(string username, string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(16);
        byte[] hash = await Task.Run(() => Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32));
        string stored = $"pbkdf2-sha256${Iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
        await using var connection = CreateConnection();
        await connection.OpenAsync();
        await using var command = new MySqlCommand("INSERT INTO `user` (`username`, `password`) VALUES (@username, @password)", connection);
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@password", stored);
        try { return await command.ExecuteNonQueryAsync() == 1; }
        catch (MySqlException ex) when (ex.Number == 1062) { return false; }
    }

    // Username-only reset requested for this local application; no ownership verification.
    internal static async Task<bool> ResetPasswordAsync(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || username.Trim().Length > 100)
            throw new ArgumentException("Enter a valid username.");
        if (password.Length < 8) throw new ArgumentException("Password must contain at least 8 characters.");
        byte[] salt = RandomNumberGenerator.GetBytes(16);
        byte[] hash = await Task.Run(() => Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32));
        string stored = $"pbkdf2-sha256${Iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
        await using var connection = CreateConnection();
        await connection.OpenAsync();
        await using var command = new MySqlCommand("UPDATE `user` SET `password` = @password WHERE `username` = @username", connection);
        command.Parameters.AddWithValue("@username", username.Trim());
        command.Parameters.AddWithValue("@password", stored);
        return await command.ExecuteNonQueryAsync() == 1;
    }
    internal static async Task<bool> LoginAsync(string username, string password)
    {
        await using var connection = CreateConnection();
        await connection.OpenAsync();
        await using var command = new MySqlCommand("SELECT `password` FROM `user` WHERE `username` = @username LIMIT 1", connection);
        command.Parameters.AddWithValue("@username", username);
        var stored = await command.ExecuteScalarAsync() as string;
        if (stored == null) return false;
        var parts = stored.Split('$');
        if (parts.Length != 4 || parts[0] != "pbkdf2-sha256" || !int.TryParse(parts[1], out int iterations) || iterations != Iterations) return false;
        try
        {
            byte[] salt = Convert.FromBase64String(parts[2]);
            byte[] expected = Convert.FromBase64String(parts[3]);
            if (salt.Length != 16 || expected.Length != 32) return false;
            byte[] actual = await Task.Run(() => Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, HashAlgorithmName.SHA256, 32));
            return CryptographicOperations.FixedTimeEquals(expected, actual);
        }
        catch (FormatException) { return false; }
    }
}

