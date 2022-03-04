using Microsoft.EntityFrameworkCore.Migrations;

namespace iSlavici.Migrations
{
    public partial class AddSubjectExaminationTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseExaminationId",
                table: "Subject",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CourseExaminationName",
                table: "Subject",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Credit",
                table: "Subject",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseExaminationId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "CourseExaminationName",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "Subject");
        }
    }
}
