using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Interfaces
{
    public interface IEpisodeService
    {

        public Episode CreateEpisode(EpisodeDto episodeDto);
        public void UpdateEpisode(EpisodeDto episodeDto);
        public void DeleteEpisode(int id);
        public IEnumerable<EpisodeDto> GetAllEpisodes();

    }
}
