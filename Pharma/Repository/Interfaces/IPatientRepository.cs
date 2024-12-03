using Pharma.Model;

namespace Pharma.Repository.Interfaces
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAll();

        Task<Patient> GetById(int id);

        Task Add(Patient patient);

        Task Update(Patient patient);

        void Delete(Patient patient);
    }
}
