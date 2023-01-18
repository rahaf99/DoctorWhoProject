using AutoMapper;
using DoctorWho.Db.Entities;
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

        //Get All Doctors from DB
        [HttpGet]
        public ActionResult<IEnumerable<DoctorDto>> GetAllDoctors()
        {
            var DoctorsFromRepository = _doctorService.GetAllDoctors();
            return new JsonResult(_mapper.Map<IEnumerable<DoctorDto>>(DoctorsFromRepository));
        }

        //Get A specific doctor from DB
        [HttpGet("{doctorId}")]
        public DoctorDto GetDoctorById(int doctorId)
        {
            return _doctorService.GetDoctorById(doctorId);
        }

        //update a specific doctor in DB if it is exist and create a new one if it is not exist
        [HttpPut]
        public ActionResult<DoctorDto> UpdateDoctor([FromBody] DoctorDto doctorDto)
        {
            if (doctorDto is null)
                return NotFound();

            if (!_doctorService.DoctorExists(doctorDto.DoctorId))
            {
                _doctorService.CreateDoctor(doctorDto);
            }
            else
            {
                _doctorService.UpdateDoctor(doctorDto);
            }
            return (_doctorService.GetDoctorById(doctorDto.DoctorId));
        }

        //Add new doctor to the DB
        [HttpPost]
        public void createDoctor([FromBody] DoctorDto doctorDto)
        {
            _doctorService.CreateDoctor(doctorDto);
        }

        //Delete a specific doctor from DB
        [HttpDelete("{DoctorId}")]
        public ActionResult DeleteDoctor(int DoctorId)
        {
            if (_doctorService.DoctorExists(DoctorId))
            {
                _doctorService.DeleteDoctor(DoctorId);
            }
            return NoContent();
        }
    }
}
