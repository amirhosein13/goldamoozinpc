using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class dorekamelkona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dorematn",
                table: "dores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dorematn",
                table: "dores");
        }
    }
}
