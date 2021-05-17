using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class javabtabdeltitr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "javabtitr",
                table: "javabs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "javabtitr",
                table: "javabs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
