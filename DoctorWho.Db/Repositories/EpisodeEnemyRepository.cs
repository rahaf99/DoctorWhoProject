using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public  class EpisodeEnemyRepository:IEpisodeEnemyRepository
    {
        DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
        public void AddEnemyToEpisode(EpisodeEnemy episodeEnemy)
        {
            _context.EpisodeEnemies.Add(episodeEnemy);
            _context.SaveChanges();
        }

    }
}
