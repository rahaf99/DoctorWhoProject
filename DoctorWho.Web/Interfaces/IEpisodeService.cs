using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Interfaces
{
    public interface IEpisodeService
    {

        public Episode CreateEpisode(EpisodeDto episodeDto);
        public void updateEpisode(EpisodeDto episodeDto);
        public void deleteEpisode(int id);
        public IEnumerable<EpisodeDto> GetAllEpisodes();

    }
}
