using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository:IEpisodeRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public EpisodeRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public Episode CreateEpisode(Episode episode)
        {
            _context.Episodes.Add(episode);
            _context.SaveChanges();
            return episode;
        }
        public void UpdateEpisode(Episode episode)
        {
            _context.Update(episode);
            _context.SaveChanges();
        }
        public void DeleteEpisode(int id)
        {
            Episode d = _context.Episodes.Find(id);
            _context.Episodes.Remove(d);
            _context.SaveChanges();
        }
        public List<Episode> GetAllEpisodes()
        {
            return _context.Episodes.ToList();

        }


    }
}
