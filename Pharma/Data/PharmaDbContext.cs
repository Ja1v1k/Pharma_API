using Microsoft.EntityFrameworkCore;
using Pharma.Model;

namespace Pharma.Data
{
    public class PharmaDbContext : DbContext
    {
        public PharmaDbContext(DbContextOptions<PharmaDbContext> options): base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
    }
}
