using DoctorWho.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Interfaces
{
    public interface IEpisodeEnemyRepository
    {
        public void AddEnemyToEpisode(EpisodeEnemy episodeEnemy);

    }
}
