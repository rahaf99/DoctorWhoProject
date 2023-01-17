using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Web.Services
{
    public class EpisodeEnemyService : IEpisodeEnemyService
    {
        private readonly DoctorWhoCoreDbContext _context;
        private readonly IEpisodeEnemyRepository _episodeEnemyRepository;
        private readonly IMapper _mapper;

        public EpisodeEnemyService(DoctorWhoCoreDbContext context, IEpisodeEnemyRepository episodeEnemyRepository, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _episodeEnemyRepository = episodeEnemyRepository;
            _mapper = mapper;
        }
        public void AddEnemyToEpisode(EpisodeEnemyDto episodeEnemyDto)
        {
            var episodeEnemy = _mapper.Map<EpisodeEnemy>(episodeEnemyDto);

            _episodeEnemyRepository.AddEnemyToEpisode(episodeEnemy);

        }

        public IEnumerable<EpisodeEnemyDto> GetAllEpisodeEnemies()
        {
            var episodeEnemies = _episodeEnemyRepository.GetAllEpisodeEnemies();
            var response = episodeEnemies.Select(x => _mapper.Map<EpisodeEnemyDto>(x));
            return response;
        }
    }
}
