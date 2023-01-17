using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Interfaces
{
    public interface IAuthorService
    {
        public void CreateAuthor(AuthorDto authorDto);
        public void UpdateAuthor(AuthorDto authorDto);
        public void DeleteAuthor(int id);
        public bool AuthorExists(int id);
        public IEnumerable<AuthorDto> GetAllAuthors();

    }
}
