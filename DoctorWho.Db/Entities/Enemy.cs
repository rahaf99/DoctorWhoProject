using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Entities
{
    public class Enemy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EnemyId { get; set; }
        [Required]
        public string EnemyName { get; set; }
        public string Description { get; set;}
        public ICollection<EpisodeEnemy> EpisodeEnemies { get;set; }
    }
}
