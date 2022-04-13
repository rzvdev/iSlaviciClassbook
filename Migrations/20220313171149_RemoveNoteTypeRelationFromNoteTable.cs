using Microsoft.EntityFrameworkCore.Migrations;

namespace iSlavici.Migrations
{
    public partial class RemoveNoteTypeRelationFromNoteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Note_NoteType_NoteTypeId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_NoteTypeId",
                table: "Note");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Note_NoteTypeId",
                table: "Note",
                column: "NoteTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Note_NoteType_NoteTypeId",
                table: "Note",
                column: "NoteTypeId",
                principalTable: "NoteType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
