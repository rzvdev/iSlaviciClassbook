using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iSlavici.Migrations
{
    public partial class AddStudentTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    ProfileId = table.Column<int>(nullable: false),
                    InYear = table.Column<int>(nullable: false),
                    StartYear = table.Column<DateTime>(nullable: false),
                    EndYear = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
