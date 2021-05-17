using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class nazaratvideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nazarat_dores_doreid",
                table: "nazarat");

            migrationBuilder.DropForeignKey(
                name: "FK_nazarat_userbombs_Userbombuserid",
                table: "nazarat");

            migrationBuilder.DropForeignKey(
                name: "FK_nazarostad_nazarat_nazaratid",
                table: "nazarostad");

            migrationBuilder.DropForeignKey(
                name: "FK_nazarostad_userbombs_Userbombuserid",
                table: "nazarostad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nazarostad",
                table: "nazarostad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nazarat",
                table: "nazarat");

            migrationBuilder.RenameTable(
                name: "nazarostad",
                newName: "nazarostads");

            migrationBuilder.RenameTable(
                name: "nazarat",
                newName: "nazarats");

            migrationBuilder.RenameIndex(
                name: "IX_nazarostad_Userbombuserid",
                table: "nazarostads",
                newName: "IX_nazarostads_Userbombuserid");

            migrationBuilder.RenameIndex(
                name: "IX_nazarostad_nazaratid",
                table: "nazarostads",
                newName: "IX_nazarostads_nazaratid");

            migrationBuilder.RenameIndex(
                name: "IX_nazarat_Userbombuserid",
                table: "nazarats",
                newName: "IX_nazarats_Userbombuserid");

            migrationBuilder.RenameIndex(
                name: "IX_nazarat_doreid",
                table: "nazarats",
                newName: "IX_nazarats_doreid");

            migrationBuilder.AddColumn<string>(
                name: "videomatn",
                table: "videodores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nazarostads",
                table: "nazarostads",
                column: "nazaraostadid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nazarats",
                table: "nazarats",
                column: "nazaratid");

            migrationBuilder.CreateTable(
                name: "nazaratvideos",
                columns: table => new
                {
                    nazaratvideoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matnnazarvideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: false),
                    videoid = table.Column<int>(type: "int", nullable: false),
                    Videodorevideoid = table.Column<int>(type: "int", nullable: true),
                    Userbombuserid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nazaratvideos", x => x.nazaratvideoid);
                    table.ForeignKey(
                        name: "FK_nazaratvideos_userbombs_Userbombuserid",
                        column: x => x.Userbombuserid,
                        principalTable: "userbombs",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_nazaratvideos_videodores_Videodorevideoid",
                        column: x => x.Videodorevideoid,
                        principalTable: "videodores",
                        principalColumn: "videoid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nazaratostadvideos",
                columns: table => new
                {
                    nazaraostadid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameostad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matnnazarostad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazaratvideoid = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    Userbombuserid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nazaratostadvideos", x => x.nazaraostadid);
                    table.ForeignKey(
                        name: "FK_nazaratostadvideos_nazaratvideos_nazaratvideoid",
                        column: x => x.nazaratvideoid,
                        principalTable: "nazaratvideos",
                        principalColumn: "nazaratvideoid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nazaratostadvideos_userbombs_Userbombuserid",
                        column: x => x.Userbombuserid,
                        principalTable: "userbombs",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_nazaratostadvideos_nazaratvideoid",
                table: "nazaratostadvideos",
                column: "nazaratvideoid");

            migrationBuilder.CreateIndex(
                name: "IX_nazaratostadvideos_Userbombuserid",
                table: "nazaratostadvideos",
                column: "Userbombuserid");

            migrationBuilder.CreateIndex(
                name: "IX_nazaratvideos_Userbombuserid",
                table: "nazaratvideos",
                column: "Userbombuserid");

            migrationBuilder.CreateIndex(
                name: "IX_nazaratvideos_Videodorevideoid",
                table: "nazaratvideos",
                column: "Videodorevideoid");

            migrationBuilder.AddForeignKey(
                name: "FK_nazarats_dores_doreid",
                table: "nazarats",
                column: "doreid",
                principalTable: "dores",
                principalColumn: "doreid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_nazarats_userbombs_Userbombuserid",
                table: "nazarats",
                column: "Userbombuserid",
                principalTable: "userbombs",
                principalColumn: "userid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_nazarostads_nazarats_nazaratid",
                table: "nazarostads",
                column: "nazaratid",
                principalTable: "nazarats",
                principalColumn: "nazaratid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_nazarostads_userbombs_Userbombuserid",
                table: "nazarostads",
                column: "Userbombuserid",
                principalTable: "userbombs",
                principalColumn: "userid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nazarats_dores_doreid",
                table: "nazarats");

            migrationBuilder.DropForeignKey(
                name: "FK_nazarats_userbombs_Userbombuserid",
                table: "nazarats");

            migrationBuilder.DropForeignKey(
                name: "FK_nazarostads_nazarats_nazaratid",
                table: "nazarostads");

            migrationBuilder.DropForeignKey(
                name: "FK_nazarostads_userbombs_Userbombuserid",
                table: "nazarostads");

            migrationBuilder.DropTable(
                name: "nazaratostadvideos");

            migrationBuilder.DropTable(
                name: "nazaratvideos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nazarostads",
                table: "nazarostads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nazarats",
                table: "nazarats");

            migrationBuilder.DropColumn(
                name: "videomatn",
                table: "videodores");

            migrationBuilder.RenameTable(
                name: "nazarostads",
                newName: "nazarostad");

            migrationBuilder.RenameTable(
                name: "nazarats",
                newName: "nazarat");

            migrationBuilder.RenameIndex(
                name: "IX_nazarostads_Userbombuserid",
                table: "nazarostad",
                newName: "IX_nazarostad_Userbombuserid");

            migrationBuilder.RenameIndex(
                name: "IX_nazarostads_nazaratid",
                table: "nazarostad",
                newName: "IX_nazarostad_nazaratid");

            migrationBuilder.RenameIndex(
                name: "IX_nazarats_Userbombuserid",
                table: "nazarat",
                newName: "IX_nazarat_Userbombuserid");

            migrationBuilder.RenameIndex(
                name: "IX_nazarats_doreid",
                table: "nazarat",
                newName: "IX_nazarat_doreid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nazarostad",
                table: "nazarostad",
                column: "nazaraostadid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nazarat",
                table: "nazarat",
                column: "nazaratid");

            migrationBuilder.AddForeignKey(
                name: "FK_nazarat_dores_doreid",
                table: "nazarat",
                column: "doreid",
                principalTable: "dores",
                principalColumn: "doreid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_nazarat_userbombs_Userbombuserid",
                table: "nazarat",
                column: "Userbombuserid",
                principalTable: "userbombs",
                principalColumn: "userid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_nazarostad_nazarat_nazaratid",
                table: "nazarostad",
                column: "nazaratid",
                principalTable: "nazarat",
                principalColumn: "nazaratid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_nazarostad_userbombs_Userbombuserid",
                table: "nazarostad",
                column: "Userbombuserid",
                principalTable: "userbombs",
                principalColumn: "userid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
