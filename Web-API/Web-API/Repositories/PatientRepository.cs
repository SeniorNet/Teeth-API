using Web_API.Interfaces;
using Web_API.Models;

namespace Web_API.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(DbManagement context) : base(context)
        {
        }
        public IEnumerable<Patient> GetPatients()
        {
            return _context.patients.OrderByDescending(d => d.UID).ToList();
        }
    }
}
