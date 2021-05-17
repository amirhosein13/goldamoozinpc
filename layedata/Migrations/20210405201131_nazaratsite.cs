using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class nazaratsite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nazarat",
                columns: table => new
                {
                    nazaratid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matnnazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: false),
                    doreid = table.Column<int>(type: "int", nullable: false),
                    Userbombuserid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nazarat", x => x.nazaratid);
                    table.ForeignKey(
                        name: "FK_nazarat_dores_doreid",
                        column: x => x.doreid,
                        principalTable: "dores",
                        principalColumn: "doreid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nazarat_userbombs_Userbombuserid",
                        column: x => x.Userbombuserid,
                        principalTable: "userbombs",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nazarostad",
                columns: table => new
                {
                    nazaraostadid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameostad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matnnazarostad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazaratid = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    Userbombuserid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nazarostad", x => x.nazaraostadid);
                    table.ForeignKey(
                        name: "FK_nazarostad_nazarat_nazaratid",
                        column: x => x.nazaratid,
                        principalTable: "nazarat",
                        principalColumn: "nazaratid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nazarostad_userbombs_Userbombuserid",
                        column: x => x.Userbombuserid,
                        principalTable: "userbombs",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_nazarat_doreid",
                table: "nazarat",
                column: "doreid");

            migrationBuilder.CreateIndex(
                name: "IX_nazarat_Userbombuserid",
                table: "nazarat",
                column: "Userbombuserid");

            migrationBuilder.CreateIndex(
                name: "IX_nazarostad_nazaratid",
                table: "nazarostad",
                column: "nazaratid");

            migrationBuilder.CreateIndex(
                name: "IX_nazarostad_Userbombuserid",
                table: "nazarostad",
                column: "Userbombuserid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nazarostad");

            migrationBuilder.DropTable(
                name: "nazarat");
        }
    }
}
