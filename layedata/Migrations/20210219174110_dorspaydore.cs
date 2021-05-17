using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class dorspaydore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "dorostbood",
                table: "payuserdores",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dorostbood",
                table: "payuserdores");
        }
    }
}
