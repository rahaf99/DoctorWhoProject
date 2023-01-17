using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Interfaces
{
    public interface ICompanionService
    {
        public IEnumerable<CompanionDto> GetAllCompanions();
        public void CreateCompanion(CompanionDto companionDto);
        public void UpdateCompanion(Companion companion);
        public void DeleteCompanion(int id);
        public void GetCompanionById(int id);
    }
}
