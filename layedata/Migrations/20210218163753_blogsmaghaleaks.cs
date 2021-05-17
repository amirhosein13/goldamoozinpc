using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class blogsmaghaleaks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "urlimage",
                table: "blogmaghales",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "urlimage",
                table: "blogmaghales");
        }
    }
}
