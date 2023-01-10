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
        public void createDoctor(Doctor doctor);
        public void updateDoctor(Doctor doctor);
        public void deleteDoctor(int id);
        public List<Doctor> GetAllDoctors();
        public bool DoctorExists(int id);
        public Doctor GetDoctorById(int id);


    }
}
