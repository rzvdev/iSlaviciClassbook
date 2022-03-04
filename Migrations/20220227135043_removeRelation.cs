using Microsoft.EntityFrameworkCore.Migrations;

namespace iSlavici.Migrations
{
    public partial class removeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Profile_ProfileId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_SubjectType_SubjectTypeId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_ProfileId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_SubjectTypeId",
                table: "Subject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Subject_ProfileId",
                table: "Subject",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectTypeId",
                table: "Subject",
                column: "SubjectTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Profile_ProfileId",
                table: "Subject",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_SubjectType_SubjectTypeId",
                table: "Subject",
                column: "SubjectTypeId",
                principalTable: "SubjectType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
