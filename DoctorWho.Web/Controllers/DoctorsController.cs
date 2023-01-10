using AutoMapper;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/Doctors")]
    public class DoctorsController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;
        public DoctorsController(IDoctorService doctorService, IMapper mapper)
        {
            _doctorService = doctorService ?? throw new ArgumentException(nameof(doctorService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<DoctorDto>> GetAllDoctors()
        {
            var DoctorsFromRepository = _doctorService.GetAllDoctors();
            return new JsonResult(_mapper.Map<IEnumerable<DoctorDto>>(DoctorsFromRepository));
        }

        [HttpPut("DoctorId")]
        public ActionResult<DoctorDto> UpdateDoctor(int DoctorId, DoctorDto doctorDto)
        {
            if (!_doctorService.DoctorExists(DoctorId))
            {
                
                _doctorService.createDoctor(doctorDto);
            }
            else
            {
                _doctorService.updateDoctor(doctorDto);
            }
            return (_doctorService.GetDoctorById(DoctorId));
        }

        [HttpDelete]
        public ActionResult DeleteDoctor(int DoctorId)
        {
            if (_doctorService.DoctorExists(DoctorId))
            {
                _doctorService.deleteDoctor(DoctorId);
            }
            return NoContent();
        }


    }
}
