using Web_API.Models;

namespace Web_API.Interfaces
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
        IEnumerable<Patient> GetPatients();
    }
}
