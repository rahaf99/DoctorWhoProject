﻿// <auto-generated />
using System;
using DoctorWho;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20230104141225_CreateFunctionFnCompanions")]
    partial class CreateFunctionFnCompanions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoctorWho.Db.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Author1"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Author2"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Author3"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Author4"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Author5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"));

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Companion1",
                            WhoPlayed = "Player1"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Companion2",
                            WhoPlayed = "Player2"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Companion3",
                            WhoPlayed = "Player3"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Companion4",
                            WhoPlayed = "Player4"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Companion5",
                            WhoPlayed = "Player5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1996, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Doctor1",
                            DoctorNumber = "123",
                            FirstEpisodeDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1997, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Doctor2",
                            DoctorNumber = "456",
                            FirstEpisodeDate = new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1998, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Doctor3",
                            DoctorNumber = "789",
                            FirstEpisodeDate = new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1999, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Doctor4",
                            DoctorNumber = "1011",
                            FirstEpisodeDate = new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Doctor5",
                            DoctorNumber = "1213",
                            FirstEpisodeDate = new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "Enemy 1 Description",
                            EnemyName = "Enemy1"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "Enemy 2 Description",
                            EnemyName = "Enemy2"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "Enemy 3 Description",
                            EnemyName = "Enemy3"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "Enemy 4 Description",
                            EnemyName = "Enemy4"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "Enemy 5 Description",
                            EnemyName = "Enemy5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "A",
                            Notes = "Episode 1.1 Notes",
                            SeriesNumber = 1,
                            Title = "Episode 1 Title"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "A",
                            Notes = "Episode 1.2 Notes",
                            SeriesNumber = 1,
                            Title = "Episode 2 Title"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "B",
                            Notes = "Episode 1.3 Notes",
                            SeriesNumber = 1,
                            Title = "Episode 3 Title"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 4,
                            EpisodeType = "B",
                            Notes = "Episode 1.4 Notes",
                            SeriesNumber = 1,
                            Title = "Episode 4 Title"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 5,
                            EpisodeType = "C",
                            Notes = "Episode 1.5 Notes",
                            SeriesNumber = 1,
                            Title = "Episode 5 Title"
                        },
                        new
                        {
                            EpisodeId = 6,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 6,
                            EpisodeType = "A",
                            Notes = "Episode 1.6 Notes",
                            SeriesNumber = 1,
                            Title = "Episode 6 Title"
                        },
                        new
                        {
                            EpisodeId = 7,
                            AuthorId = 4,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "C",
                            Notes = "Episode 2.1 Notes",
                            SeriesNumber = 2,
                            Title = "Episode 1 Title"
                        },
                        new
                        {
                            EpisodeId = 8,
                            AuthorId = 4,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "A",
                            Notes = "Episode 2.2 Notes",
                            SeriesNumber = 2,
                            Title = "Episode 2 Title"
                        },
                        new
                        {
                            EpisodeId = 9,
                            AuthorId = 5,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "B",
                            Notes = "Episode 2.3 Notes",
                            SeriesNumber = 2,
                            Title = "Episode 3 Title"
                        },
                        new
                        {
                            EpisodeId = 10,
                            AuthorId = 5,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 4,
                            EpisodeType = "C",
                            Notes = "Episode 2.4 Notes",
                            SeriesNumber = 2,
                            Title = "Episode 4 Title"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeCompanionId"));

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanions");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 2,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 3,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeCompanionId = 6,
                            CompanionId = 3,
                            EpisodeId = 6
                        },
                        new
                        {
                            EpisodeCompanionId = 7,
                            CompanionId = 4,
                            EpisodeId = 7
                        },
                        new
                        {
                            EpisodeCompanionId = 8,
                            CompanionId = 4,
                            EpisodeId = 8
                        },
                        new
                        {
                            EpisodeCompanionId = 9,
                            CompanionId = 5,
                            EpisodeId = 9
                        },
                        new
                        {
                            EpisodeCompanionId = 10,
                            CompanionId = 5,
                            EpisodeId = 10
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"));

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemies");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 2,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 3,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeEnemyId = 6,
                            EnemyId = 3,
                            EpisodeId = 6
                        },
                        new
                        {
                            EpisodeEnemyId = 7,
                            EnemyId = 4,
                            EpisodeId = 7
                        },
                        new
                        {
                            EpisodeEnemyId = 8,
                            EnemyId = 4,
                            EpisodeId = 8
                        },
                        new
                        {
                            EpisodeEnemyId = 9,
                            EnemyId = 5,
                            EpisodeId = 9
                        },
                        new
                        {
                            EpisodeEnemyId = 10,
                            EnemyId = 5,
                            EpisodeId = 10
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Entities.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Entities.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.Entities.Companion", "Companion")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Entities.Episode", "Episode")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.Entities.Enemy", "Enemy")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Entities.Episode", "Episode")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.Companion", b =>
                {
                    b.Navigation("EpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.Enemy", b =>
                {
                    b.Navigation("EpisodeEnemies");
                });

            modelBuilder.Entity("DoctorWho.Db.Entities.Episode", b =>
                {
                    b.Navigation("EpisodeCompanions");

                    b.Navigation("EpisodeEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}
