using AutoMapper;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
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


        [HttpPut("AuthorId")]
        public void UpdateAuthor(int AuthorId, AuthorDto authorDto)
        {
            if (!_authorService.AuthorExists(AuthorId))
            {

                _authorService.createAuthor(authorDto);
            }
            else
            {
                _authorService.updateAuthor(authorDto);
            }

        }
    }
}
