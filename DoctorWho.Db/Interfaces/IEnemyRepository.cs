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
        public void createEnemy(Enemy enemy);
        public void updateEnemy(Enemy enemy);
        public void deleteEnemy(int id);
        public void GetEnemyById(int id);


    }
}
