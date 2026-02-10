using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyOrganizationRegistrationSystem.Migrations
{
    /// <inheritdoc />
    public partial class MakeOrgSurveyColumnsUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OrgSurveyName",
                table: "OrgSurveys",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OrgName",
                table: "OrgSurveys",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_OrgSurveys_OrgName_OrgSurveyName",
                table: "OrgSurveys",
                columns: new[] { "OrgName", "OrgSurveyName" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrgSurveys_OrgName_OrgSurveyName",
                table: "OrgSurveys");

            migrationBuilder.AlterColumn<string>(
                name: "OrgSurveyName",
                table: "OrgSurveys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "OrgName",
                table: "OrgSurveys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
