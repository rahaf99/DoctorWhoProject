using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Services
{
    public interface IAuthorService
    {
        public void createAuthor(AuthorDto authorDto);
        public void updateAuthor(AuthorDto authorDto );
        public void deleteAuthor(int id);
        public bool AuthorExists(int id);

    }
}
