using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class javabtabrevasl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Userbombuserid",
                table: "Soals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "Soals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Userbombuserid",
                table: "javabs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "javabs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Soals_Userbombuserid",
                table: "Soals",
                column: "Userbombuserid");

            migrationBuilder.CreateIndex(
                name: "IX_javabs_Userbombuserid",
                table: "javabs",
                column: "Userbombuserid");

            migrationBuilder.AddForeignKey(
                name: "FK_javabs_userbombs_Userbombuserid",
                table: "javabs",
                column: "Userbombuserid",
                principalTable: "userbombs",
                principalColumn: "userid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Soals_userbombs_Userbombuserid",
                table: "Soals",
                column: "Userbombuserid",
                principalTable: "userbombs",
                principalColumn: "userid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_javabs_userbombs_Userbombuserid",
                table: "javabs");

            migrationBuilder.DropForeignKey(
                name: "FK_Soals_userbombs_Userbombuserid",
                table: "Soals");

            migrationBuilder.DropIndex(
                name: "IX_Soals_Userbombuserid",
                table: "Soals");

            migrationBuilder.DropIndex(
                name: "IX_javabs_Userbombuserid",
                table: "javabs");

            migrationBuilder.DropColumn(
                name: "Userbombuserid",
                table: "Soals");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "Soals");

            migrationBuilder.DropColumn(
                name: "Userbombuserid",
                table: "javabs");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "javabs");
        }
    }
}
