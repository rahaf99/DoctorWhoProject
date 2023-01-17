using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Interfaces
{
    public interface IEpisodeCompanionService
    {
        public void AddCompanionToEpisode(EpisodeCompanionDto episodeCompanionDto);
        public IEnumerable<EpisodeCompanionDto> GetAllEpisodeCompanions();

    }
}
