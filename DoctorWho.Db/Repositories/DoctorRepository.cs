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
        
        public void createDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }
        public void updateDoctor(Doctor doctor)
        {
            _context.Update(doctor);
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
        public Doctor GetDoctorById(int id)
        {
            Doctor d = _context.Doctors.Find(id);
            return d;
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
