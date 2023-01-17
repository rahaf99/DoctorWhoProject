using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Services
{
    public class EpisodeCompanionService : IEpisodeCompanionService
    {
        private readonly DoctorWhoCoreDbContext _context;
        private readonly IEpisodeCompanionRepository _episodeCompanionRepository;
        private readonly IMapper _mapper;

        public EpisodeCompanionService(DoctorWhoCoreDbContext context, IEpisodeCompanionRepository episodeCompanionRepository, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _episodeCompanionRepository = episodeCompanionRepository;
            _mapper = mapper;
        }
        public void AddCompanionToEpisode(EpisodeCompanionDto episodeCompanionDto)
        {
            var episodeCompanion = _mapper.Map<EpisodeCompanion>(episodeCompanionDto);

            _episodeCompanionRepository.AddCompanionToEpisode(episodeCompanion);

        }

        public IEnumerable<EpisodeCompanionDto> GetAllEpisodeCompanions()
        {
            var episodeCompanions = _episodeCompanionRepository.GetAllEpisodeCompanions();
            var response = episodeCompanions.Select(x => _mapper.Map<EpisodeCompanionDto>(x));
            return response;
        }
    }
}
