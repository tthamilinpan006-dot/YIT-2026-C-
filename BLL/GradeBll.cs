using System;
using System.Data;
using System.Threading.Tasks;
using WinFormsApp1.DAL;

namespace WinFormsApp1.BLL
{
    internal class GradeBll
    {
        public string ValidationError { get; private set; } = string.Empty;

        private Task<bool> Reject(string message)
        {
            ValidationError = message;
            return Task.FromResult(false);
        }

        private readonly GradeDAL dal = new GradeDAL();

        public Task<DataTable> GetAll()
        {
            ValidationError = string.Empty;
            return dal.GetAll();
        }

        public Task<DataTable> GetByIdAsync(string id)
        {
            ValidationError = string.Empty;
            if (string.IsNullOrWhiteSpace(id))
                return Task.FromResult(new DataTable());
            return dal.GetByIdAsync(id);
        }

        public Task<bool> InsertAsync(string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
            ValidationError = string.Empty;
            if (string.IsNullOrWhiteSpace(gradeName) || string.IsNullOrWhiteSpace(gradeGroup) || string.IsNullOrWhiteSpace(gradeOrder))
                return Reject("Please check the required fields, IDs, dates and grade order.");
            if (!int.TryParse(gradeOrder, out int order) || order < 0)
                return Reject("Please check the required fields, IDs, dates and grade order.");
            return dal.InsertAsync(gradeName.Trim(), gradeGroup.Trim(), gradeOrder.Trim(), (colour ?? string.Empty).Trim());
        }

        public Task<bool> UpdateAsync(string id, string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
            ValidationError = string.Empty;
            if (string.IsNullOrWhiteSpace(id))
                return Reject("Please check the required fields, IDs, dates and grade order.");
            if (string.IsNullOrWhiteSpace(gradeName) || string.IsNullOrWhiteSpace(gradeGroup) || string.IsNullOrWhiteSpace(gradeOrder))
                return Reject("Please check the required fields, IDs, dates and grade order.");
            if (!int.TryParse(gradeOrder, out int order) || order < 0)
                return Reject("Please check the required fields, IDs, dates and grade order.");
            return dal.UpdateAsync(id.Trim(), gradeName.Trim(), gradeGroup.Trim(), gradeOrder.Trim(), (colour ?? string.Empty).Trim());
        }

        public Task<bool> DeleteAsync(string id)
        {
            ValidationError = string.Empty;
            if (string.IsNullOrWhiteSpace(id))
                return Reject("Please check the required fields, IDs, dates and grade order.");
            return dal.DeleteAsync(id);
        }
    }
}



