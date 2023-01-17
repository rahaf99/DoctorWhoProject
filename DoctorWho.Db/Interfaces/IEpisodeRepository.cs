using DoctorWho.Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Interfaces
{
    public interface IEpisodeRepository
    {
        public Episode CreateEpisode(Episode episode);
        public void UpdateEpisode(Episode episode);
        public void DeleteEpisode(int id);
        public List<Episode> GetAllEpisodes();


    }
}
