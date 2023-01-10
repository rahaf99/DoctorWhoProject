using DoctorWho.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public  class EpisodeEnemyRepository
    {
        DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
        public void AddEnemyToEpisode(int EpisodeId, int EnemyId)
        {
            EpisodeEnemy ee = new EpisodeEnemy { EpisodeId = EpisodeId, EnemyId = EnemyId };
            _context.EpisodeEnemies.Add(ee);
            _context.SaveChanges();
        }

    }
}
