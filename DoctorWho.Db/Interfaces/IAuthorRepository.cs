using DoctorWho.Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Interfaces
{
    public interface IAuthorRepository
    {
        public void CreateAuthor(Author author);
        public void UpdateAuthor(Author author);
        public void DeleteAuthor(int id);
        public bool AuthorExists(int id);
        public List<Author> GetAllAuthors();

    }
}
