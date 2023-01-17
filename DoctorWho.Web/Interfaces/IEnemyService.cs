using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Interfaces
{
    public interface IEnemyService
    {
        public void CreateEnemy(EnemyDto enemyDto);
        public void UpdateEnemy(EnemyDto enemyDto);
        public void DeleteEnemy(int EnemyId);
        public void GetEnemyById(int EnemyId);
        public IEnumerable<EnemyDto> GetAllEnemies();

    }
}
