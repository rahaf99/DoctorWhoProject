using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class CreateStoredProcedureSpSummariseEpisodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var proc = @"CREATE OR ALTER PROCEDURE spSummariseEpisodes
                        AS
                        SELECT TOP (3)
                        WITH TIES e.CompanionName
                        FROM Companions e
                        INNER JOIN EpisodeCompanions ec ON e.CompanionId = ec.CompanionId
                        GROUP BY e.CompanionName
                        ORDER BY COUNT(ec.CompanionId) DESC

                        SELECT TOP (3)
                        WITH TIES e.EnemyName
                        FROM Enemies e
                        INNER JOIN EpisodeEnemies ec ON e.EnemyId = ec.EnemyId
                        GROUP BY e.EnemyName
                        ORDER BY COUNT(ec.EnemyId) DESC";
            migrationBuilder.Sql(proc);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var proc = "DROP PROCEDURE spSummariseEpisodes";
            migrationBuilder.Sql(proc);

        }
    }
}
