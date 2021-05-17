using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class userdore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doreusers",
                columns: table => new
                {
                    doreuserid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doreid = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    Userbombuserid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doreusers", x => x.doreuserid);
                    table.ForeignKey(
                        name: "FK_Doreusers_dores_doreid",
                        column: x => x.doreid,
                        principalTable: "dores",
                        principalColumn: "doreid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doreusers_userbombs_Userbombuserid",
                        column: x => x.Userbombuserid,
                        principalTable: "userbombs",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doreusers_doreid",
                table: "Doreusers",
                column: "doreid");

            migrationBuilder.CreateIndex(
                name: "IX_Doreusers_Userbombuserid",
                table: "Doreusers",
                column: "Userbombuserid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doreusers");
        }
    }
}
