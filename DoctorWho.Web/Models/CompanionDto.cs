﻿using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Web.Models
{
    public class CompanionDto
    {
        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }
    }
}
