using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class jdarasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_javabs_Soals_soalid",
                table: "javabs");

            migrationBuilder.AlterColumn<int>(
                name: "userid",
                table: "javabs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "soalid",
                table: "javabs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "modarsgofte",
                table: "javabs",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddForeignKey(
                name: "FK_javabs_Soals_soalid",
                table: "javabs",
                column: "soalid",
                principalTable: "Soals",
                principalColumn: "soalid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_javabs_Soals_soalid",
                table: "javabs");

            migrationBuilder.AlterColumn<int>(
                name: "userid",
                table: "javabs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "soalid",
                table: "javabs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "modarsgofte",
                table: "javabs",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_javabs_Soals_soalid",
                table: "javabs",
                column: "soalid",
                principalTable: "Soals",
                principalColumn: "soalid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
