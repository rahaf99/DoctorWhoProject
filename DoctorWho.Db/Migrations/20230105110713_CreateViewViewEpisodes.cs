using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.Metrics;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class CreateViewViewEpisodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var view = @"CREATE OR ALTER VIEW ViewEpisodes
                        AS
                        SELECT e.*
	                        ,a.AuthorName
	                        ,d.DoctorName
	                        ,dbo.fnCompanions(e.EpisodeId) AS Companions
	                        ,[dbo].[fnEnemies](e.EpisodeId) AS Enemies
                        FROM Episodes e
                        INNER JOIN Authors a ON e.AuthorId = a.AuthorId
                        INNER JOIN Doctors d ON e.DoctorId = d.DoctorId";
            migrationBuilder.Sql(view);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var view = "DROP VIEW ViewEpisodes";
            migrationBuilder.Sql(view);
        }
    }
}
