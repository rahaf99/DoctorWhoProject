using DoctorWho.Db.Entities;

namespace DoctorWho.Web.Models
{
    public class EpisodeCompanionDto
    {
        public int EpisodeCompanionId { get; set; }
        public int EpisodeId { get; set; }
        public int CompanionId { get; set; }

    }
}
