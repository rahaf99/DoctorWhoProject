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

        //Get All Authors from DB
        [HttpGet]
        public ActionResult<IEnumerable<AuthorDto>> GetAllAuthors()
        {
            var AuthorsFromRepository = _authorService.GetAllAuthors();
            return new JsonResult(_mapper.Map<IEnumerable<AuthorDto>>(AuthorsFromRepository));
        }

        //Add new Author to DB
        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor(AuthorDto authorDto)
        {
            _authorService.CreateAuthor(authorDto);
            AuthorDto response = _mapper.Map<AuthorDto>(authorDto);
            return response;
        }

        //upserting 
        // update the author if it is exists and create a new one if it is not found 
        [HttpPut]
        public void UpdateAuthor(AuthorDto authorDto)
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

        // delete a specific author from DB
        [HttpDelete("{authorId}")]
        public void DeleteAuthor(int authorId)
        {
            if (_authorService.AuthorExists(authorId))
            {
                _authorService.DeleteAuthor(authorId);
            }
            
        }



    }
}
