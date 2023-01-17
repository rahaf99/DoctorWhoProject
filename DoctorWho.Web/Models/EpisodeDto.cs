using DoctorWho.Db.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Web.Models
{
    public class EpisodeDto
    {
        public int EpisodeId { get; set; }

        public int SeriesNumber { get; set; }
        
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public int DoctorId { get; set; }
        public string Notes { get; set; }

    }
}
