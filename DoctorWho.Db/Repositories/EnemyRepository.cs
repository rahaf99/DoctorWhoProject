using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository: IEnemyRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public EnemyRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void createEnemy(Enemy enemy)
        {
            _context.Enemies.Add(enemy);
            _context.SaveChanges();
        }
        public void updateEnemy(Enemy enemy)
        {
            _context.Update(enemy);
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
