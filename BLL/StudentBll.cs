using System;
using System.Data;
using System.Threading.Tasks;
using WinFormsApp1.DAL;

namespace WinFormsApp1.BLL
{
    internal class StudentBll
    {
        public string ValidationError { get; private set; } = string.Empty;

        private Task<bool> Reject(string message)
        {
            ValidationError = message;
            return Task.FromResult(false);
        }

        private readonly StudentDal dal = new StudentDal();

        public Task<DataTable> GetAllAsync()
        {
            ValidationError = string.Empty;
            return dal.GetAllAsync();
        }

        public Task<DataTable> GetByIdAsync(string id)
        {
            ValidationError = string.Empty;
            if (string.IsNullOrWhiteSpace(id))
                return Task.FromResult(new DataTable());
            return dal.GetByIdAsync(id);
        }

        public Task<bool> DeleteAsync(string id)
        {
            ValidationError = string.Empty;
            if (string.IsNullOrWhiteSpace(id))
                return Reject("Please check the required fields, IDs, dates and grade order.");
            return dal.DeleteAsync(id);
        }

        public Task<bool> InsertAsync(string admissionNumber,
                string firstName,
                string lastName,
                string gender,
                DateTime dateOfBirth,
                string nicNumber,
                string birthCertificateNumber,
                string telephone,
                string address,
                string gradeId,
                string houseName,
                string medium,
                string familyMobile,
                DateTime dateOfAdmission)
        {
            ValidationError = string.Empty;
            if (string.IsNullOrWhiteSpace(admissionNumber) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(gradeId) || string.IsNullOrWhiteSpace(medium))
                return Reject("Please check the required fields, IDs, dates and grade order.");
            if (dateOfBirth.Date > DateTime.Today || dateOfAdmission.Date < dateOfBirth.Date)
                return Reject("Please check the required fields, IDs, dates and grade order.");
            return dal.InsertAsync(admissionNumber.Trim(), firstName.Trim(), lastName.Trim(), gender.Trim(), dateOfBirth, (nicNumber ?? string.Empty).Trim(), (birthCertificateNumber ?? string.Empty).Trim(), (telephone ?? string.Empty).Trim(), (address ?? string.Empty).Trim(), gradeId.Trim(), (houseName ?? string.Empty).Trim(), medium.Trim(), (familyMobile ?? string.Empty).Trim(), dateOfAdmission);
        }

        public Task<bool> UpdateAsync(string id,
                    string admissionNumber,
                    string firstName,
                    string lastName,
                    string gender,
                    string nicNumber,
                    string birthCertificateNumber,
                    string telephone,
                    string address,
                    string gradeId,
                    string houseName,
                    string medium,
                    string familyMobile,
                    DateTime dateOfBirth,
                    DateTime dateOfAdmission)
        {
            ValidationError = string.Empty;
            if (string.IsNullOrWhiteSpace(id))
                return Reject("Please check the required fields, IDs, dates and grade order.");
            if (string.IsNullOrWhiteSpace(admissionNumber) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(gradeId) || string.IsNullOrWhiteSpace(medium))
                return Reject("Please check the required fields, IDs, dates and grade order.");
            if (dateOfBirth.Date > DateTime.Today || dateOfAdmission.Date < dateOfBirth.Date)
                return Reject("Please check the required fields, IDs, dates and grade order.");
            return dal.UpdateAsync(id.Trim(), admissionNumber.Trim(), firstName.Trim(), lastName.Trim(), gender.Trim(), (nicNumber ?? string.Empty).Trim(), (birthCertificateNumber ?? string.Empty).Trim(), (telephone ?? string.Empty).Trim(), (address ?? string.Empty).Trim(), gradeId.Trim(), (houseName ?? string.Empty).Trim(), medium.Trim(), (familyMobile ?? string.Empty).Trim(), dateOfBirth, dateOfAdmission);
        }
    }
}



