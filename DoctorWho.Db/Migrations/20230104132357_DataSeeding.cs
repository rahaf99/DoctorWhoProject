using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Author1" },
                    { 2, "Author2" },
                    { 3, "Author3" },
                    { 4, "Author4" },
                    { 5, "Author5" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 1, "Companion1", "Player1" },
                    { 2, "Companion2", "Player2" },
                    { 3, "Companion3", "Player3" },
                    { 4, "Companion4", "Player4" },
                    { 5, "Companion5", "Player5" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1996, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor1", "123", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1997, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor2", "456", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1998, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor3", "789", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1999, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor4", "1011", new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor5", "1213", new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 1, "Enemy 1 Description", "Enemy1" },
                    { 2, "Enemy 2 Description", "Enemy2" },
                    { 3, "Enemy 3 Description", "Enemy3" },
                    { 4, "Enemy 4 Description", "Enemy4" },
                    { 5, "Enemy 5 Description", "Enemy5" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A", "Episode 1.1 Notes", 1, "Episode 1 Title" },
                    { 2, 1, 1, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "A", "Episode 1.2 Notes", 1, "Episode 2 Title" },
                    { 3, 2, 2, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "B", "Episode 1.3 Notes", 1, "Episode 3 Title" },
                    { 4, 2, 2, new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "B", "Episode 1.4 Notes", 1, "Episode 4 Title" },
                    { 5, 3, 3, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "C", "Episode 1.5 Notes", 1, "Episode 5 Title" },
                    { 6, 3, 3, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "A", "Episode 1.6 Notes", 1, "Episode 6 Title" },
                    { 7, 4, 4, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "C", "Episode 2.1 Notes", 2, "Episode 1 Title" },
                    { 8, 4, 4, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "A", "Episode 2.2 Notes", 2, "Episode 2 Title" },
                    { 9, 5, 5, new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "B", "Episode 2.3 Notes", 2, "Episode 3 Title" },
                    { 10, 5, 5, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "C", "Episode 2.4 Notes", 2, "Episode 4 Title" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);
        }
    }
}
