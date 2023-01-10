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
        public void createAuthor(Author author);
        public void updateAuthor(Author author);
        public void deleteAuthor(int id);
        public bool AuthorExists(int id);

    }
}
