﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetHospital.BusinessLogic.Models;
using InternetHospital.DataAccess;
using InternetHospital.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InternetHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private ApplicationContext _context;
        public DoctorsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Doctors
        [HttpGet]
        public IQueryable<DoctorsDto> GetDoctors()
        {
            var doctors = _context.Doctors.Select(d => new DoctorsDto
            {
                Id = d.UserId,
                FirstName = d.User.FirstName,
                SecondName = d.User.SecondName,
                ThirdName = d.User.ThirdName,
                SpecializationName = d.Specialization.Name
            });
            return doctors;
        }
    }
}