using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
using DoctorWho.Web.Validators;
using FluentValidation.Results;
using System.Numerics;

namespace DoctorWho.Web.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly DoctorWhoCoreDbContext _context;
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;
        private readonly DoctorValidator _doctorValidator;
        public DoctorService(DoctorWhoCoreDbContext context, IDoctorRepository repository, IMapper mapper, DoctorValidator doctorValidator)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _repository = repository;
            _mapper = mapper;
            _doctorValidator = doctorValidator;
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
            var response = _mapper.Map<DoctorDto>(doctor);
            return response;
        }

        public void updateDoctor(DoctorDto doctorDto)
        {
            ValidationResult result = _doctorValidator.Validate(doctorDto);
            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    Console.WriteLine("Property" + failure.PropertyName + "Failed Validation Error was:" + failure.ErrorMessage);
                }
            }
            else
            {
                var doctor = _mapper.Map<Doctor>(doctorDto);
                _repository.UpdateDoctor(doctor);
            }
        }
        public void createDoctor(DoctorDto doctorDto)
        {
            ValidationResult result = _doctorValidator.Validate(doctorDto);
            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    Console.WriteLine("Property" + failure.PropertyName + "Failed Validation Error was:" + failure.ErrorMessage);
                }
            }
            else
            {
                var doctor = _mapper.Map<Doctor>(doctorDto);
                _repository.CreateDoctor(doctor);
            }

        }

        public void deleteDoctor(int DoctorId)
        {
            _repository.DeleteDoctor(DoctorId);
        }
    }
}
