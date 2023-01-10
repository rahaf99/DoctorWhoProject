﻿using AutoMapper;
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
        public DoctorsController(IDoctorService doctorService,IMapper mapper)
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
    }
}