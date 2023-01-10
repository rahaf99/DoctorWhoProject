using DoctorWho.Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository
    {
        DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
        public void AddCompanionToEpisode(int EpisodeId, int CompanionId)
        {
            EpisodeCompanion ec = new EpisodeCompanion { EpisodeId = EpisodeId, CompanionId = CompanionId };
            _context.EpisodeCompanions.Add(ec);
            _context.SaveChanges();
        }

    }
}
