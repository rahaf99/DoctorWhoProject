using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Models
{
    public class Companion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CompanionId { get; set; }

        [Required]
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }
        public ICollection<EpisodeCompanion> EpisodeCompanions { get;set; }


    }
}
