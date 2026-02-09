using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyOrganizationRegistrationSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrgSurveys",
                columns: table => new
                {
                    OrgName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrgSurveyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgSurveyDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgSurveys", x => x.OrgName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrgSurveys");
        }
    }
}
