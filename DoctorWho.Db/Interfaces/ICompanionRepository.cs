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
        public void createCompanion(Companion companion );
        public void updateCompanion(Companion companion);
        public void deleteCompanion(int id);
        public void GetCompanionById(int id);


    }
}
