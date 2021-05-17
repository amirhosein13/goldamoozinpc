using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class jdar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "javabdahande",
                table: "javabs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "javabdahande",
                table: "javabs");
        }
    }
}
