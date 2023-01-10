using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Services
{
    public interface IEpisodeCompanionService
    {
        public void AddCompanionToEpisode(EpisodeCompanionDto episodeCompanionDto);

    }
}
