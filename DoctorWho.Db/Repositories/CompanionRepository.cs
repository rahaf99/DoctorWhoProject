using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository
    {
        DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public  void createCompanion(string name, string who)
        {
            Companion c = new Companion { CompanionName = name, WhoPlayed = who };
            _context.Companions.Add(c);
            _context.SaveChanges();
        }
        public  void updateCompanion(int id, string newName, string newPlayer)
        {
            Companion c = new Companion { CompanionId = id, CompanionName = newName, WhoPlayed = newPlayer };
            _context.Update(c);
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
