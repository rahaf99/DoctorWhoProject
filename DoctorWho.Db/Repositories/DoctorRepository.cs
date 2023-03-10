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
        private readonly DoctorWhoCoreDbContext _context;
        
        public DoctorRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void CreateDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }
        public void UpdateDoctor(Doctor doctor)
        {
            _context.Update(doctor);
            _context.SaveChanges();
        }
        public void DeleteDoctor(int id)
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
             return _context.Doctors.Any(m=>m.DoctorId==id);
        }
  
    }
}
