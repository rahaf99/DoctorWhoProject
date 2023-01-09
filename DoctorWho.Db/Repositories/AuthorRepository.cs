using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        DoctorWhoCoreDbContext _context= new DoctorWhoCoreDbContext();
        public  void createAuthor(string name)
        {
            Author a = new Author { AuthorName = name };
            _context.Authors.Add(a);
            _context.SaveChanges();
        }
        public  void updateAuthor(int id, string newName)
        {
            Author c = new Author { AuthorId = id, AuthorName = newName };
            _context.Update(c);
            _context.SaveChanges();
        }
        public  void deleteAuthor(int id)
        {
            Author c = _context.Authors.Find(id);
            _context.Authors.Remove(c);
            _context.SaveChanges();
        }

    }
}
