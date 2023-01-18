using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Interfaces
{
    public interface IDoctorService
    {
        public IEnumerable<DoctorDto> GetAllDoctors();
        public bool DoctorExists(int DoctorId);
        public DoctorDto GetDoctorById(int DoctorId);
        public void UpdateDoctor(DoctorDto doctor);
        public void CreateDoctor(DoctorDto doctor);
        public void DeleteDoctor(int DoctorId);

    }
}
