using Microsoft.EntityFrameworkCore.Migrations;

namespace iSlavici.Migrations
{
    public partial class RemovedPersonRelationFromNoteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Note_Person_PersonId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_PersonId",
                table: "Note");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Note",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Note",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Note_PersonId",
                table: "Note",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Person_PersonId",
                table: "Note",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
