using Microsoft.EntityFrameworkCore.Migrations;

namespace iSlavici.Migrations
{
    public partial class AddRelationshipBetweenAccountAndPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        

         

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Account",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Account_PersonId",
                table: "Account",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Person_PersonId",
                table: "Account",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Person_PersonId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_PersonId",
                table: "Account");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Account",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Account_PersonId",
                table: "Account",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Person_PersonId",
                table: "Account",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
