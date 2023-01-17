using DoctorWho.Web.Models;

namespace DoctorWho.Web.Interfaces
{
    public interface IEpisodeEnemyService
    {
        public void AddEnemyToEpisode(EpisodeEnemyDto episodeEnemyDto);
        public IEnumerable<EpisodeEnemyDto> GetAllEpisodeEnemies();

    }
}
