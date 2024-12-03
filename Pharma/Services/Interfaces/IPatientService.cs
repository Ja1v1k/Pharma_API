using Pharma.Model;

namespace Pharma.Services.Interfaces
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllPatient();
        Task<Patient> GetPatientById(int id);
        Task AddPatient(Patient Patient);
        Task UpdatePatient(Patient patient);
        void DeletePatient(Patient patient);
    }
}
