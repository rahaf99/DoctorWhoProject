using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class CreateFunctionFnCompanions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var Func = @"CREATE OR ALTER FUNCTION fnCompanions (@EpisodeId INT)
                        RETURNS VARCHAR(MAX)
                        AS
                        BEGIN
	                        DECLARE @output VARCHAR(MAX);

	                        SELECT @output = CONCAT (c.CompanionName
			                        ,','
			                        ,@output
			                        )
	                        FROM Companions c
	                        INNER JOIN EpisodeCompanions ec ON c.CompanionId = ec.CompanionId
	                        WHERE ec.EpisodeId = @EpisodeId

	                        RETURN @output
                        END;";


            migrationBuilder.Sql(Func);
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var Func = "DROP FUNCTION fnCompanions";
            migrationBuilder.Sql(Func);
        }
    }
}
