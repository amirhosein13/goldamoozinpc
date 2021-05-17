using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class dorekamelkon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dores",
                columns: table => new
                {
                    doreid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dorename = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    doremodars = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dorehgaymat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dorebargozary = table.Column<bool>(type: "bit", nullable: false),
                    doretedadgalase = table.Column<int>(type: "int", nullable: false),
                    doretedaddaneshamooz = table.Column<int>(type: "int", nullable: false),
                    doretedadsaatbargozary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doresath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doreakharinberoozresany = table.Column<DateTime>(type: "datetime2", nullable: false),
                    doreimageurl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dores", x => x.doreid);
                });

            migrationBuilder.CreateTable(
                name: "videodores",
                columns: table => new
                {
                    videoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    videoname = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    urlvideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doreid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videodores", x => x.videoid);
                    table.ForeignKey(
                        name: "FK_videodores_dores_doreid",
                        column: x => x.doreid,
                        principalTable: "dores",
                        principalColumn: "doreid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_videodores_doreid",
                table: "videodores",
                column: "doreid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "videodores");

            migrationBuilder.DropTable(
                name: "dores");
        }
    }
}
