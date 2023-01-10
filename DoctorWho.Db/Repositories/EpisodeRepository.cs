using DoctorWho.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public void createEpisode(int SeriesNumber, int EpisodeNumber, string EpisodeType, string Title, DateTime EpisodeDate, int AuthorId, int DoctorId, string Notes)
        {
            Episode e = new Episode { SeriesNumber = SeriesNumber, EpisodeNumber = EpisodeNumber, EpisodeType = EpisodeType, Title = Title, EpisodeDate = EpisodeDate, AuthorId = AuthorId, DoctorId = DoctorId, Notes = Notes };
            _context.Episodes.Add(e);
            _context.SaveChanges();
        }
        public void updateEpisode(int id, int SeriesNumber, int EpisodeNumber, string EpisodeType, string Title, DateTime EpisodeDate, int AuthorId, int DoctorId, string Notes)
        {
            Episode e = new Episode { EpisodeId = id, SeriesNumber = SeriesNumber, EpisodeNumber = EpisodeNumber, EpisodeType = EpisodeType, Title = Title, EpisodeDate = EpisodeDate, AuthorId = AuthorId, DoctorId = DoctorId, Notes = Notes };
            _context.Update(e);
            _context.SaveChanges();
        }
        public void deleteEpisode(int id)
        {
            Episode d = _context.Episodes.Find(id);
            _context.Episodes.Remove(d);
            _context.SaveChanges();
        }


    }
}
