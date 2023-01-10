using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository:IEpisodeCompanionRepository
    {
        DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
        public void AddCompanionToEpisode(EpisodeCompanion episodeCompanion)
        {
            _context.EpisodeCompanions.Add(episodeCompanion);
            _context.SaveChanges();
        }

    }
}
