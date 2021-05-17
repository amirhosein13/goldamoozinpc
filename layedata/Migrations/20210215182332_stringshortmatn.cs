using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class stringshortmatn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "shortmatn",
                table: "dores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "shortmatn",
                table: "dores");
        }
    }
}
