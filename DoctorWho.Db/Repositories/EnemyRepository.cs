using DoctorWho.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository
    {
        DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public void createEnemy(string name, string Description)
        {
            Enemy e = new Enemy { EnemyName = name, Description = Description };
            _context.Enemies.Add(e);
            _context.SaveChanges();
        }
        public void updateEnemy(int id, string name, string Description)
        {
            Enemy e = new Enemy { EnemyId = id, EnemyName = name, Description = Description };
            _context.Update(e);
            _context.SaveChanges();
        }
        public void deleteEnemy(int id)
        {
            Enemy d = _context.Enemies.Find(id);
            _context.Enemies.Remove(d);
            _context.SaveChanges();
        }
        public void GetEnemyById(int id)
        {
            var Enemy = _context.Enemies.Find(id);
            Console.WriteLine(Enemy.EnemyName);
        }

    }
}
