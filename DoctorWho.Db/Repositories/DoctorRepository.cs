using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository
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
        public void GetAllDoctors()
        {
            var Doctors = _context.Doctors.ToList();
            foreach (var doctor in Doctors)
            {
                Console.WriteLine(doctor.DoctorName);
            }
        }

    }
}
