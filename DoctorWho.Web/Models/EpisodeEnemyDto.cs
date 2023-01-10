using DoctorWho.Db.Entities;

namespace DoctorWho.Web.Models
{
    public class EpisodeEnemyDto
    {
        public int EpisodeEnemyId { get; set; }
        public int EpisodeId { get; set; }
        public int EnemyId { get; set; }
    }
}
