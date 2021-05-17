using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class usernamemodblog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "usernamemodars",
                table: "blogmaghales",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "usernamemodars",
                table: "blogmaghales");
        }
    }
}
