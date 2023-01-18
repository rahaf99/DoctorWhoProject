using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/Enemies")]
    public class EnemyController : Controller
    {
        private readonly IEnemyService _enemyService;
        private readonly IEpisodeEnemyService _episodeEnemyService;
        private readonly IMapper _mapper;
        public EnemyController(IEnemyService enemyService, IEpisodeEnemyService episodeEnemyService, IMapper mapper)
        {
            _enemyService = enemyService ?? throw new ArgumentException(nameof(enemyService));
            _episodeEnemyService = episodeEnemyService ?? throw new ArgumentException(nameof(episodeEnemyService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        
        //Get all enemies from DB
        [HttpGet]
        public ActionResult<IEnumerable<EnemyDto>> GetAllEnemies()
        {
            var EnemiesFromRepository = _enemyService.GetAllEnemies();
            return new JsonResult(_mapper.Map<IEnumerable<EnemyDto>>(EnemiesFromRepository));
        }

        //Add a new Enemy to DB
        [HttpPost]
        public ActionResult<EnemyDto> CreateEnemy([FromBody] EnemyDto enemyDto)
        {
            _enemyService.CreateEnemy(enemyDto);
            EnemyDto response = _mapper.Map<EnemyDto>(enemyDto);
            return response;
        }
        /*
        [HttpGet("GetAllEnemiesToEpisode")]
        public ActionResult<IEnumerable<EpisodeEnemyDto>> GetAllEpisodeEnemies()
        {
            var EpisodeEnemiesFromRepository = _episodeEnemyService.GetAllEpisodeEnemies();
            return new JsonResult(_mapper.Map<IEnumerable<EpisodeEnemyDto>>(EpisodeEnemiesFromRepository));
        }
        */
        //link an existing Enemy to a specific Episode 
        [HttpPost("LinkEpisodeToEnemy")]
        public void AddEnemyToEpisode([FromBody] EpisodeEnemyDto episodeEnemyDto)
        {
            _episodeEnemyService.AddEnemyToEpisode(episodeEnemyDto);

        }
    }
}
