using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using DoctorWho.Web.Models;
using System.Numerics;

namespace DoctorWho.Web.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly DoctorWhoCoreDbContext _context;
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;

        public DoctorService(DoctorWhoCoreDbContext context,IDoctorRepository repository,IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<DoctorDto> GetAllDoctors()
        {
           var doctors = _repository.GetAllDoctors();
            var response = doctors.Select(x => _mapper.Map<DoctorDto>(x));
            return response;
        }
        public bool DoctorExists(int DoctorId)
        {
            var response = _repository.DoctorExists(DoctorId);
            return response;
        }

        public DoctorDto GetDoctorById(int DoctorId)
        {
            var doctor = _repository.GetDoctorById(DoctorId);
            var response =  _mapper.Map<DoctorDto>(doctor);
            return response;
        }

        public void updateDoctor(DoctorDto doctorDto)
        {
            var doctor = _mapper.Map<Doctor>(doctorDto);
            _repository.updateDoctor(doctor);
        }
        public void createDoctor(DoctorDto doctorDto)
        {
            var doctor = _mapper.Map<Doctor>(doctorDto);
            _repository.createDoctor(doctor);
        }


    }
}
