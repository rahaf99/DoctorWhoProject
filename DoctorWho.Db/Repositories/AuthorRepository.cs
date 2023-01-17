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
        public  void CreateAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
        public  void UpdateAuthor(Author author)
        {
            _context.Update(author);
            _context.SaveChanges();
        }
        public  void DeleteAuthor(int id)
        {
            Author c = _context.Authors.Find(id);
            _context.Authors.Remove(c);
            _context.SaveChanges();
        }
        public bool AuthorExists(int id)
        {
            return _context.Authors.Any(a => a.AuthorId == id);
        }
        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();

        }
    }
}
