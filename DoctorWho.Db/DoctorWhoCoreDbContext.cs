using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho
{
    public class DoctorWhoCoreDbContext:DbContext
    {
        public DoctorWhoCoreDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D0JS7AA;Database=DoctorWhoCore;Integrated Security=True;Trusted_Connection=True;Trust Server Certificate=true;");
        }
        public DbSet<Author> Authors { get; set; }  
        public DbSet<Companion> Companions { get; set; } 
        public DbSet<Doctor> Doctors { get; set; }  
        public DbSet<Enemy> Enemies { get; set; }   
        public DbSet<Episode> Episodes { get; set;}
       public DbSet<EpisodeCompanion> EpisodeCompanions { get; set; }
        public DbSet<EpisodeEnemy> EpisodeEnemies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>().HasData
                (
                new Author { AuthorId = 1, AuthorName = "Author1" },
                new Author { AuthorId = 2, AuthorName = "Author2" },
                new Author { AuthorId = 3, AuthorName = "Author3" },
                new Author { AuthorId = 4, AuthorName = "Author4" },
                new Author { AuthorId = 5, AuthorName = "Author5" }
                );

            modelBuilder.Entity<Companion>().HasData
                (
                new Companion { CompanionId = 1, CompanionName = "Companion1", WhoPlayed = "Player1" },
                new Companion { CompanionId = 2, CompanionName = "Companion2", WhoPlayed = "Player2" },
                new Companion { CompanionId = 3, CompanionName = "Companion3", WhoPlayed = "Player3" },
                new Companion { CompanionId = 4, CompanionName = "Companion4", WhoPlayed = "Player4" },
                new Companion { CompanionId = 5, CompanionName = "Companion5", WhoPlayed = "Player5" }
                );

            modelBuilder.Entity<Doctor>().HasData
                (
                new Doctor { DoctorId = 1, DoctorNumber = "123", DoctorName = "Doctor1", BirthDate = new DateTime(1996, 01, 11), FirstEpisodeDate = new DateTime(2023, 01, 01), LastEpisodeDate = new DateTime(2023, 01, 02) },
                new Doctor { DoctorId = 2, DoctorNumber = "456", DoctorName = "Doctor2", BirthDate = new DateTime(1997, 02, 22), FirstEpisodeDate = new DateTime(2023, 01, 03), LastEpisodeDate = new DateTime(2023, 01, 04) },
                new Doctor { DoctorId = 3, DoctorNumber = "789", DoctorName = "Doctor3", BirthDate = new DateTime(1998, 03, 30), FirstEpisodeDate = new DateTime(2023, 01, 05), LastEpisodeDate = new DateTime(2023, 01, 06) },
                new Doctor { DoctorId = 4, DoctorNumber = "1011", DoctorName = "Doctor4", BirthDate = new DateTime(1999, 04, 14), FirstEpisodeDate = new DateTime(2023, 01, 07), LastEpisodeDate = new DateTime(2023, 01, 08) },
                new Doctor { DoctorId = 5, DoctorNumber = "1213", DoctorName = "Doctor5", BirthDate = new DateTime(2000, 05, 15), FirstEpisodeDate = new DateTime(2023, 01, 09), LastEpisodeDate = new DateTime(2023, 01, 10) }
                );
            modelBuilder.Entity<Enemy>().HasData
                (
                new Enemy { EnemyId = 1, EnemyName = "Enemy1", Description = "Enemy 1 Description"},
                new Enemy { EnemyId = 2, EnemyName = "Enemy2", Description = "Enemy 2 Description"},
                new Enemy { EnemyId = 3, EnemyName = "Enemy3", Description = "Enemy 3 Description"},
                new Enemy { EnemyId = 4, EnemyName = "Enemy4", Description = "Enemy 4 Description"},
                new Enemy { EnemyId = 5, EnemyName = "Enemy5", Description = "Enemy 5 Description"}
                );
            modelBuilder.Entity<Episode>().HasData
                (
                new Episode { EpisodeId = 1, SeriesNumber = 1, EpisodeNumber = 1, EpisodeType = "A", Title = "Episode 1 Title", EpisodeDate = new DateTime(2023, 01, 01), AuthorId = 1, DoctorId = 1, Notes = "Episode 1.1 Notes" },
                new Episode { EpisodeId = 2, SeriesNumber = 1, EpisodeNumber = 2, EpisodeType = "A", Title = "Episode 2 Title", EpisodeDate = new DateTime(2023, 01, 02), AuthorId = 1, DoctorId = 1, Notes = "Episode 1.2 Notes" },
                new Episode { EpisodeId = 3, SeriesNumber = 1, EpisodeNumber = 3, EpisodeType = "B", Title = "Episode 3 Title", EpisodeDate = new DateTime(2023, 01, 03), AuthorId = 2, DoctorId = 2, Notes = "Episode 1.3 Notes" },
                new Episode { EpisodeId = 4, SeriesNumber = 1, EpisodeNumber = 4, EpisodeType = "B", Title = "Episode 4 Title", EpisodeDate = new DateTime(2023, 01, 04), AuthorId = 2, DoctorId = 2, Notes = "Episode 1.4 Notes" },
                new Episode { EpisodeId = 5, SeriesNumber = 1, EpisodeNumber = 5, EpisodeType = "C", Title = "Episode 5 Title", EpisodeDate = new DateTime(2023, 01, 05), AuthorId = 3, DoctorId = 3, Notes = "Episode 1.5 Notes" },
                new Episode { EpisodeId = 6, SeriesNumber = 1, EpisodeNumber = 6, EpisodeType = "A", Title = "Episode 6 Title", EpisodeDate = new DateTime(2023, 01, 06), AuthorId = 3, DoctorId = 3, Notes = "Episode 1.6 Notes" },
                
                new Episode { EpisodeId = 7, SeriesNumber = 2, EpisodeNumber = 1, EpisodeType = "C", Title = "Episode 1 Title", EpisodeDate = new DateTime(2023, 01, 07), AuthorId = 4, DoctorId = 4, Notes = "Episode 2.1 Notes" },
                new Episode { EpisodeId = 8, SeriesNumber = 2, EpisodeNumber = 2, EpisodeType = "A", Title = "Episode 2 Title", EpisodeDate = new DateTime(2023, 01, 08), AuthorId = 4, DoctorId = 4, Notes = "Episode 2.2 Notes" },
                new Episode { EpisodeId = 9, SeriesNumber = 2, EpisodeNumber = 3, EpisodeType = "B", Title = "Episode 3 Title", EpisodeDate = new DateTime(2023, 01, 09), AuthorId = 5, DoctorId = 5, Notes = "Episode 2.3 Notes" },
                new Episode { EpisodeId = 10, SeriesNumber = 2, EpisodeNumber = 4, EpisodeType = "C", Title = "Episode 4 Title", EpisodeDate = new DateTime(2023, 01, 10), AuthorId = 5, DoctorId = 5, Notes = "Episode 2.4 Notes" }

                );
            modelBuilder.Entity<EpisodeCompanion>().HasData
                (
                new EpisodeCompanion { EpisodeCompanionId = 1, EpisodeId = 1, CompanionId = 1 },
                new EpisodeCompanion { EpisodeCompanionId = 2, EpisodeId = 2, CompanionId = 1 },
                new EpisodeCompanion { EpisodeCompanionId = 3, EpisodeId = 3, CompanionId = 2 },
                new EpisodeCompanion { EpisodeCompanionId = 4, EpisodeId = 4, CompanionId = 2 },
                new EpisodeCompanion { EpisodeCompanionId = 5, EpisodeId = 5, CompanionId = 3 },
                new EpisodeCompanion { EpisodeCompanionId = 6, EpisodeId = 6, CompanionId = 3 },
                new EpisodeCompanion { EpisodeCompanionId = 7, EpisodeId = 7, CompanionId = 4 },
                new EpisodeCompanion { EpisodeCompanionId = 8, EpisodeId = 8, CompanionId = 4 },
                new EpisodeCompanion { EpisodeCompanionId = 9, EpisodeId = 9, CompanionId = 5 },
                new EpisodeCompanion { EpisodeCompanionId = 10, EpisodeId = 10, CompanionId = 5 }
                );
            modelBuilder.Entity<EpisodeEnemy>().HasData
                (
                new EpisodeEnemy { EpisodeEnemyId = 1, EpisodeId = 1, EnemyId = 1 },
                new EpisodeEnemy { EpisodeEnemyId = 2, EpisodeId = 2, EnemyId = 1 },
                new EpisodeEnemy { EpisodeEnemyId = 3, EpisodeId = 3, EnemyId = 2 },
                new EpisodeEnemy { EpisodeEnemyId = 4, EpisodeId = 4, EnemyId = 2 },
                new EpisodeEnemy { EpisodeEnemyId = 5, EpisodeId = 5, EnemyId = 3 },
                new EpisodeEnemy { EpisodeEnemyId = 6, EpisodeId = 6, EnemyId = 3 },
                new EpisodeEnemy { EpisodeEnemyId = 7, EpisodeId = 7, EnemyId = 4 },
                new EpisodeEnemy { EpisodeEnemyId = 8, EpisodeId = 8, EnemyId = 4 },
                new EpisodeEnemy { EpisodeEnemyId = 9, EpisodeId = 9, EnemyId = 5 },
                new EpisodeEnemy { EpisodeEnemyId = 10, EpisodeId = 10, EnemyId = 5 }
                );

        }
    }
}
