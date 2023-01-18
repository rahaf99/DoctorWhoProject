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

        [HttpGet]
        public ActionResult<IEnumerable<EpisodeDto>> GetAllEpisodes()
        {
            var EpisodesFromRepository = _episodeService.GetAllEpisodes();
            return new JsonResult(_mapper.Map<IEnumerable<EpisodeDto>>(EpisodesFromRepository));
        }

        [HttpPost]
        public ActionResult<EpisodeDto> CreateEpisode([FromBody] EpisodeDto episodeDto)
        {
            _episodeService.CreateEpisode(episodeDto);
            EpisodeDto response = _mapper.Map<EpisodeDto>(episodeDto);
            return response;
        }

        [HttpDelete("{episodeId}")]
        public void deleteEpisode(int episodeId)
        {
            _episodeService.deleteEpisode(episodeId);
        }

        [HttpPut]
        public void updateEpisode([FromBody]EpisodeDto episodeDto)
        {
            _episodeService.updateEpisode(episodeDto);
        }
    }
}
