using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Web.Services
{
    public class CompanionService: ICompanionService
    {
        private readonly DoctorWhoCoreDbContext _context;
        private readonly ICompanionRepository _companionRepository;
        private readonly IMapper _mapper;
        public CompanionService(DoctorWhoCoreDbContext context, ICompanionRepository companionRepository, IMapper mapper)
        {
            _context = context;
            _companionRepository = companionRepository;
            _mapper = mapper;
        }
        public IEnumerable<CompanionDto> GetAllCompanions()
        {
            var Companions = _companionRepository.GetAllCompanions();
            var response = Companions.Select(x => _mapper.Map<CompanionDto>(x));
            return response;
        }


        public void CreateCompanion(CompanionDto companionDto)
        {
            var companion = _mapper.Map<Companion>(companionDto);
            _companionRepository.CreateCompanion(companion);
        }



        public void UpdateCompanion(Companion companion)
        {
     
        }
        public void DeleteCompanion(int id)
        {
          
        }
        public void GetCompanionById(int id)
        {
 
        }
    }
}
