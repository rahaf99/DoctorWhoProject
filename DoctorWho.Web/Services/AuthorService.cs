using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
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
        public void createAuthor(AuthorDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            _authorRepository.createAuthor(author);

        }
        public void updateAuthor(AuthorDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            _authorRepository.updateAuthor(author);

        }
        public void deleteAuthor(int id)
        {

        }

        public bool AuthorExists(int AuthorId)
        {
            var response = _authorRepository.AuthorExists(AuthorId);
            return response;
        }

    }
}
