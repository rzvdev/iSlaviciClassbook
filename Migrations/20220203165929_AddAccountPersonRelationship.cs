using Microsoft.EntityFrameworkCore.Migrations;

namespace iSlavici.Migrations
{
    public partial class AddAccountPersonRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Account");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Person",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Person_AccountId",
                table: "Person",
                column: "AccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Account_AccountId",
                table: "Person",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Account_AccountId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_AccountId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
