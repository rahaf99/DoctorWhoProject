using AutoMapper;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/Authors")]
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        private readonly IMapper _mapper;
        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService ?? throw new ArgumentException(nameof(authorService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<AuthorDto>> GetAllAuthors()
        {
            var AuthorsFromRepository = _authorService.GetAllAuthors();
            return new JsonResult(_mapper.Map<IEnumerable<AuthorDto>>(AuthorsFromRepository));
        }

        [HttpPut]
        public void UpdateAuthor( AuthorDto authorDto)
        {
            if (!_authorService.AuthorExists(authorDto.AuthorId))
            {

                _authorService.CreateAuthor(authorDto);
            }
            else
            {
                _authorService.UpdateAuthor(authorDto);
            }

        }
    }
}
