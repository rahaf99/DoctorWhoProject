using DoctorWho.Db.Entities;
using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Web.Models
{
    public class DoctorDto
    {
        public int DoctorId { get; set; }
        [Required]
        public string DoctorNumber { get; set; }
        [Required]
        public string DoctorName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
    }
}
