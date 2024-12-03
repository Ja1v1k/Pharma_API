using Microsoft.EntityFrameworkCore;
using Pharma.Data;
using Pharma.Model;
using Pharma.Repository.Interfaces;

namespace Pharma.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PharmaDbContext _context;

        public PatientRepository(PharmaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetAll()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<Patient> GetById(int id)
        {
            return await _context.Patients.FindAsync(id);
        }

        public async Task Add(Patient patient)
        {
            await _context.Patients.AddAsync(patient);
            await _context.SaveChangesAsync();

        }

        public async Task Update(Patient patient)
        {
            _context.Patients.Update(patient);
            await _context.SaveChangesAsync();
        }

        public void Delete(Patient patient)
        {
            _context.Patients.Remove(patient);
        }



    }
}
