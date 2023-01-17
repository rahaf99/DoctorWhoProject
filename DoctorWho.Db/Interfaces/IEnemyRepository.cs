using DoctorWho.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Interfaces
{
    public interface IEnemyRepository
    {
        public void CreateEnemy(Enemy enemy);
        public void UpdateEnemy(Enemy enemy);
        public void DeleteEnemy(int id);
        public void GetEnemyById(int id);
        public List<Enemy> GetAllEnemies();


    }
}
