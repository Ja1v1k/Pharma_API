using Pharma.Model;
using Pharma.Repository;
using Pharma.Repository.Interfaces;
using Pharma.Services.Interfaces;

namespace Pharma.Services
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<IEnumerable<Patient>> GetAllPatient() 
        {
            return await _patientRepository.GetAll();
        }

        public async Task<Patient> GetPatientById(int id)
        {
            return await _patientRepository.GetById(id);
        }

        public async Task AddPatient(Patient patient)
        {
            await _patientRepository.Add(patient);
        }

        public async Task UpdatePatient(Patient patient)
        {
            await _patientRepository.Update(patient);
        }

        public void DeletePatient(Patient patient)
        {
            _patientRepository?.Delete(patient);
        }
    }
}
