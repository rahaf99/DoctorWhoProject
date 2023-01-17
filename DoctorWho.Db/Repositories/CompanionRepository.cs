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
        public IEnumerable<Companion> GetAllCompanions()
        {
            return _context.Companions.ToList();
        }
        public void CreateCompanion(Companion companion)
        {
            _context.Companions.Add(companion);
            _context.SaveChanges();
        }
        public  void UpdateCompanion(Companion companion)
        {
            _context.Update(companion);
            _context.SaveChanges();
        }
        public  void DeleteCompanion(int id)
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
