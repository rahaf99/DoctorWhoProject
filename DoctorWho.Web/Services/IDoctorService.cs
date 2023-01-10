using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Services
{
    public interface IDoctorService
    {
        public IEnumerable<DoctorDto> GetAllDoctors();
        public bool DoctorExists(int DoctorId);
    }
}
