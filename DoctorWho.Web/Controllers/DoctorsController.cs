using AutoMapper;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
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

        [HttpPut]
        public ActionResult<DoctorDto> UpdateDoctor([FromBody]DoctorDto doctorDto)
        {
            if (doctorDto is null)
                return NotFound();
            
            if (!_doctorService.DoctorExists(doctorDto.DoctorId))
            {
                _doctorService.createDoctor(doctorDto);
            }
            else
            {
                _doctorService.updateDoctor(doctorDto);
            }
            return (_doctorService.GetDoctorById(doctorDto.DoctorId));
        }

        [HttpDelete("{DoctorId}")]
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
