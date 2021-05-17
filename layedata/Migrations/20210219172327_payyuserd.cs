using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class payyuserd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "payuserdores",
                columns: table => new
                {
                    payuserid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<int>(type: "int", nullable: false),
                    doreid = table.Column<int>(type: "int", nullable: false),
                    ghaymat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payuserdores", x => x.payuserid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "payuserdores");
        }
    }
}
