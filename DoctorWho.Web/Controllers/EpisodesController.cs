using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/Episodes")]
    public class EpisodesController : Controller
    {
        private readonly IEpisodeService _episodeService;
        private readonly IMapper _mapper;
        public EpisodesController(IEpisodeService episodeService, IMapper mapper)
        {
            _episodeService = episodeService ?? throw new ArgumentException(nameof(episodeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        //Get All Episodes from DB
        [HttpGet]
        public ActionResult<IEnumerable<EpisodeDto>> GetAllEpisodes()
        {
            var EpisodesFromRepository = _episodeService.GetAllEpisodes();
            return new JsonResult(_mapper.Map<IEnumerable<EpisodeDto>>(EpisodesFromRepository));
        }

        //Add a new Episode to DB
        [HttpPost]
        public ActionResult<EpisodeDto> CreateEpisode([FromBody] EpisodeDto episodeDto)
        {
            _episodeService.CreateEpisode(episodeDto);
            EpisodeDto response = _mapper.Map<EpisodeDto>(episodeDto);
            return response;
        }

        //Delete a specific Episode from DB
        [HttpDelete("{episodeId}")]
        public void DeleteEpisode(int episodeId)
        {
            _episodeService.DeleteEpisode(episodeId);
        }

        //Update an existing Episode
        [HttpPut]
        public void UpdateEpisode([FromBody]EpisodeDto episodeDto)
        {
            _episodeService.UpdateEpisode(episodeDto);
        }
    }
}
