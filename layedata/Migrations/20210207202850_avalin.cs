using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class avalin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    roleid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rolename = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.roleid);
                });

            migrationBuilder.CreateTable(
                name: "userbombs",
                columns: table => new
                {
                    userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userpassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    useremail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    useractivatecode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    useractiveaya = table.Column<bool>(type: "bit", nullable: false),
                    roleid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userbombs", x => x.userid);
                    table.ForeignKey(
                        name: "FK_userbombs_roles_roleid",
                        column: x => x.roleid,
                        principalTable: "roles",
                        principalColumn: "roleid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userbombs_roleid",
                table: "userbombs",
                column: "roleid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userbombs");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
