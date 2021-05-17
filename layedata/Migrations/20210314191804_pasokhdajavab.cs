using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class pasokhdajavab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "pasokhdorostnood",
                table: "javabs",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pasokhdorostnood",
                table: "javabs");
        }
    }
}
