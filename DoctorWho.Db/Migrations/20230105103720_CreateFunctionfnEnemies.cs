using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class CreateFunctionfnEnemies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var Func = @"CREATE OR ALTER FUNCTION fnEnemies (@EpisodeId INT)
                            RETURNS VARCHAR(MAX)
                            AS
                            BEGIN
	                            DECLARE @output VARCHAR(MAX);

	                            SELECT @output = CONCAT (
			                            e.EnemyName
			                            ,','
			                            ,@output
			                            )
	                            FROM Enemies e
	                            INNER JOIN EpisodeEnemies ec ON e.EnemyId = ec.EnemyId
	                            WHERE ec.EpisodeId = @EpisodeId

	                            RETURN @output
                            END;";


            migrationBuilder.Sql(Func);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var Func = "DROP FUNCTION fnEnemies";
            migrationBuilder.Sql(Func);
        }
    }
}
