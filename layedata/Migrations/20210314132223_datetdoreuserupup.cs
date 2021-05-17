using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class datetdoreuserupup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "datenowbahal",
                table: "Doreusers");

            migrationBuilder.AddColumn<DateTime>(
                name: "datenowbahal",
                table: "payuserdores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "datenowbahal",
                table: "payuserdores");

            migrationBuilder.AddColumn<DateTime>(
                name: "datenowbahal",
                table: "Doreusers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
