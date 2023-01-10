using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository:IDoctorRepository
    {
        DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
        
        public void createDoctor(string number, string name, DateTime BirthDate, DateTime FirstEpisodeDate, DateTime LastEpisodeDate)
        {

            Doctor d = new Doctor { DoctorNumber = number, DoctorName = name, BirthDate = BirthDate, FirstEpisodeDate = FirstEpisodeDate, LastEpisodeDate = LastEpisodeDate };
            _context.Doctors.Add(d);
            _context.SaveChanges();
        }
        public void updateDoctor(int id, string number, string name, DateTime BirthDate, DateTime FirstEpisodeDate, DateTime LastEpisodeDate)
        {
            Doctor d = new Doctor { DoctorId = id, DoctorNumber = number, DoctorName = name, BirthDate = BirthDate, FirstEpisodeDate = FirstEpisodeDate, LastEpisodeDate = LastEpisodeDate };
            _context.Update(d);
            _context.SaveChanges();
        }
        public void deleteDoctor(int id)
        {
            Doctor d = _context.Doctors.Find(id);
            _context.Doctors.Remove(d);
            _context.SaveChanges();
        }
        public List<Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
     
        }

        public bool DoctorExists(int id)
        {
            Doctor d = _context.Doctors.Find(id);
            if(!d.Equals(null))
                return true;
            return false;
        }
    }
}
