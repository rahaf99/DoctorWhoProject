using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/Episodes")]
    public class EpisodesController : Controller
    {
        private readonly IEpisodeService _episodeService;
        private readonly IEpisodeEnemyService _episodeEnemyService;
        private readonly IEpisodeCompanionService _episodeCompanionService;
        private readonly IMapper _mapper;
        public EpisodesController(IEpisodeService episodeService, IMapper mapper)
        {
            _episodeService = episodeService ?? throw new ArgumentException(nameof(episodeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<EpisodeDto>> GetAllEpisodes()
        {
            var EpisodesFromRepository = _episodeService.GetAllEpisodes();
            return new JsonResult(_mapper.Map<IEnumerable<EpisodeDto>>(EpisodesFromRepository));
        }

        [HttpPost]
        public ActionResult<Episode> CreateEpisode(EpisodeDto episodeDto)
        {
            _episodeService.createEpisode(episodeDto);
            Episode response = _mapper.Map<Episode>(episodeDto);
            return response;
        }

        [HttpPost]
        public void AddEnemyToEpisode(EpisodeEnemyDto episodeEnemyDto)
        {
            _episodeEnemyService.AddEnemyToEpisode(episodeEnemyDto);

        }

        [HttpPost]
        public void AddCompanionToEpisode(EpisodeCompanionDto episodeCompanionDto)
        {
            _episodeCompanionService.AddCompanionToEpisode(episodeCompanionDto);

        }
    }
}
