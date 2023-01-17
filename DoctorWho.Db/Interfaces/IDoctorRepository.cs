using DoctorWho.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Interfaces
{
    public interface IDoctorRepository
    {
        public void CreateDoctor(Doctor doctor);
        public void UpdateDoctor(Doctor doctor);
        public void DeleteDoctor(int id);
        public List<Doctor> GetAllDoctors();
        public bool DoctorExists(int id);
        public Doctor GetDoctorById(int id);


    }
}
