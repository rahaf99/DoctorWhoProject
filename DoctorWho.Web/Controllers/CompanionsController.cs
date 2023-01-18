using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/Companions")]
    public class CompanionsController : Controller
    {
        private readonly ICompanionService _companionService;
        private readonly IEpisodeCompanionService _episodeCompanionService;
        private readonly IMapper _mapper;
        public CompanionsController(ICompanionService companionService,IEpisodeCompanionService episodeCompanionService, IMapper mapper)
        {
            _companionService= companionService ?? throw new ArgumentException(nameof(companionService));
            _episodeCompanionService = episodeCompanionService ?? throw new ArgumentException(nameof(episodeCompanionService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        //Get all companions from DB
        [HttpGet]
        public ActionResult<IEnumerable<CompanionDto>> GetAllCompanions()
        {
            var CompanionsFromRepository = _companionService.GetAllCompanions();
            return new JsonResult(_mapper.Map<IEnumerable<CompanionDto>>(CompanionsFromRepository));
        }

        //Add new Companion to DB
        [HttpPost]
        public ActionResult<CompanionDto> CreateCompanion([FromBody] CompanionDto companionDto)
        {
            _companionService.CreateCompanion(companionDto);
            CompanionDto response = _mapper.Map<CompanionDto>(companionDto);
            return response;
        }

        /*
        [HttpGet("GetAllCompanionsToEpisode")]
        public ActionResult<IEnumerable<EpisodeCompanionDto>> GetAllEpisodeCompanions()
        {
            var EpisodeCompanionsFromRepository = _episodeCompanionService.GetAllEpisodeCompanions();
            return new JsonResult(_mapper.Map<IEnumerable<EpisodeCompanionDto>>(EpisodeCompanionsFromRepository));
        }
        */

        //link an existing Companion to an existing Episode

        [HttpPost("LinkEpisodeToCompanion")]
        public void AddCompanionToEpisode([FromBody] EpisodeCompanionDto episodeCompanionDto)
        {
            _episodeCompanionService.AddCompanionToEpisode(episodeCompanionDto);

        }

    }
}
