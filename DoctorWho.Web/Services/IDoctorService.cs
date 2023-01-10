using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Services
{
    public interface IDoctorService
    {
        public IEnumerable<DoctorDto> GetAllDoctors();
        public bool DoctorExists(int DoctorId);
        public DoctorDto GetDoctorById(int DoctorId);
        public void updateDoctor(DoctorDto doctor);
        public void createDoctor(DoctorDto doctor);
        public void deleteDoctor(int DoctorId);

    }
}
