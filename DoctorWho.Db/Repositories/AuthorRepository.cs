using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository:IAuthorRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public AuthorRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public  void createAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
        public  void updateAuthor(Author author)
        {
            _context.Update(author);
            _context.SaveChanges();
        }
        public  void deleteAuthor(int id)
        {
            Author c = _context.Authors.Find(id);
            _context.Authors.Remove(c);
            _context.SaveChanges();
        }
        public bool AuthorExists(int id)
        {
            Author a = _context.Authors.Find(id);
            if (!a.Equals(null))
                return true;
            return false;
        }
    }
}
