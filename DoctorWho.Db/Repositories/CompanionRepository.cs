using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository: ICompanionRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public CompanionRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public  void createCompanion(Companion companion)
        {
            _context.Companions.Add(companion);
            _context.SaveChanges();
        }
        public  void updateCompanion(Companion companion)
        {
            _context.Update(companion);
            _context.SaveChanges();
        }
        public  void deleteCompanion(int id)
        {
            Companion c = _context.Companions.Find(id);
            _context.Companions.Remove(c);
            _context.SaveChanges();
        }
        public void GetCompanionById(int id)
        {
            var Companion = _context.Companions.Find(id);
            Console.WriteLine(Companion.CompanionName);
        }

    }
}
