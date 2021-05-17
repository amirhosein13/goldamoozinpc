using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class javabtabmodargof : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "modarsgofte",
                table: "javabs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "modarsgofte",
                table: "javabs");
        }
    }
}
