using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class blogsmaghale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.CreateTable(
                name: "blogmaghales",
                columns: table => new
                {
                    blogmaghaleid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matnkootahblog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matnkamelblog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    userbombuserid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogmaghales", x => x.blogmaghaleid);
                    table.ForeignKey(
                        name: "FK_blogmaghales_userbombs_userbombuserid",
                        column: x => x.userbombuserid,
                        principalTable: "userbombs",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogmaghales_userbombuserid",
                table: "blogmaghales",
                column: "userbombuserid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogmaghales");

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    blogid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    matnkamelblog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matnkootahblog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    titr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userbombuserid = table.Column<int>(type: "int", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.blogid);
                    table.ForeignKey(
                        name: "FK_Blogs_userbombs_userbombuserid",
                        column: x => x.userbombuserid,
                        principalTable: "userbombs",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_userbombuserid",
                table: "Blogs",
                column: "userbombuserid");
        }
    }
}
