using DoctorWho.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Interfaces
{
    public interface ICompanionRepository
    {
        public IEnumerable<Companion> GetAllCompanions();
        public void CreateCompanion(Companion companion );
        public void UpdateCompanion(Companion companion);
        public void DeleteCompanion(int id);
        public void GetCompanionById(int id);


    }
}
