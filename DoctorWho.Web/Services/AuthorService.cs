using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
using DoctorWho.Web.Validators;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Web.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly DoctorWhoCoreDbContext _context;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public AuthorService(DoctorWhoCoreDbContext context, IAuthorRepository authorRepository, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public IEnumerable<AuthorDto> GetAllAuthors()
        {
            var authors = _authorRepository.GetAllAuthors();
            var response = authors.Select(x => _mapper.Map<AuthorDto>(x));
            return response;
        }

        public void CreateAuthor(AuthorDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            _authorRepository.CreateAuthor(author);

        }
        public void UpdateAuthor(AuthorDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            _authorRepository.UpdateAuthor(author);

        }
        public void DeleteAuthor(int authorId)
        {
            _authorRepository.DeleteAuthor(authorId);
        }

        public bool AuthorExists(int AuthorId)
        {
            var response = _authorRepository.AuthorExists(AuthorId);
            return response;
        }

    }
}
