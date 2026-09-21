using MySqlConnector;
//using MySqlConnector
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1.DAL
{
    internal class GradeDAL
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public async Task<DataTable> GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                await using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    await conn.OpenAsync();

                    await using MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades", conn);
                    await using MySqlDataReader reader = await cmd.ExecuteReaderAsync();

                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        public async Task<DataTable> GetByIdAsync(string id)
        {
            DataTable dt = new DataTable();

            await using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    await conn.OpenAsync();

                    string sql = "SELECT * FROM grades WHERE id = @id";

                    await using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        await using (MySqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return dt;
            }
        }

        public async Task<bool> InsertAsync(string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
            await using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    await conn.OpenAsync();

                    string sql = "INSERT INTO grades ";
                    sql += "(grade_name, grade_group, grade_order, colour) ";
                    sql += "VALUES (@grade_name, @grade_group, @grade_order, @colour)";

                    await using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@grade_name", gradeName);
                        cmd.Parameters.AddWithValue("@grade_group", gradeGroup);
                        cmd.Parameters.AddWithValue("@grade_order", gradeOrder);
                        cmd.Parameters.AddWithValue("@colour", colour);

                        int result = await cmd.ExecuteNonQueryAsync();

                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public async Task<bool> UpdateAsync(string id, string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
            await using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    await conn.OpenAsync();

                    string sql = "UPDATE grades SET ";
                    sql += "grade_name = @grade_name, ";
                    sql += "grade_group = @grade_group, ";
                    sql += "grade_order = @grade_order, ";
                    sql += "colour = @colour ";
                    sql += "WHERE id = @id";

                    await using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@grade_name", gradeName);
                        cmd.Parameters.AddWithValue("@grade_group", gradeGroup);
                        cmd.Parameters.AddWithValue("@grade_order", gradeOrder);
                        cmd.Parameters.AddWithValue("@colour", colour);

                        int result = await cmd.ExecuteNonQueryAsync();

                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            await using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    await conn.OpenAsync();

                    string sql = "DELETE FROM grades WHERE id = @id";

                    await using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int result = await cmd.ExecuteNonQueryAsync();

                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
    }
}