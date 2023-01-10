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
        public Episode createEpisode(Episode episode);
        public void updateEpisode(Episode episode);
        public void deleteEpisode(int id);
        public List<Episode> GetAllEpisodes();


    }
}
