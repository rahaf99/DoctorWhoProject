using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Services
{
    public interface IEpisodeService
    {

        public Episode createEpisode(EpisodeDto episodeDto);
        public void updateEpisode(EpisodeDto episodeDto);
        public void deleteEpisode(int id);
        public IEnumerable<EpisodeDto> GetAllEpisodes();

    }
}
