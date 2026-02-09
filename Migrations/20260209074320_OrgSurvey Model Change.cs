using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyOrganizationRegistrationSystem.Migrations
{
    /// <inheritdoc />
    public partial class OrgSurveyModelChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrgSurveys",
                table: "OrgSurveys");

            migrationBuilder.AlterColumn<string>(
                name: "OrgName",
                table: "OrgSurveys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrgSurveys",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrgSurveys",
                table: "OrgSurveys",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrgSurveys",
                table: "OrgSurveys");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrgSurveys");

            migrationBuilder.AlterColumn<string>(
                name: "OrgName",
                table: "OrgSurveys",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrgSurveys",
                table: "OrgSurveys",
                column: "OrgName");
        }
    }
}
