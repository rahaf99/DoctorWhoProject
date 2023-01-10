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
        public void createDoctor(string number, string name, DateTime BirthDate, DateTime FirstEpisodeDate, DateTime LastEpisodeDate);
        public void updateDoctor(int id, string number, string name, DateTime BirthDate, DateTime FirstEpisodeDate, DateTime LastEpisodeDate);
        public void deleteDoctor(int id);
        public List<Doctor> GetAllDoctors();
        public bool DoctorExists(int id);


    }
}
