using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class javabtabre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "javabs",
                columns: table => new
                {
                    javabid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    javabtitr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    javabmatn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zamimejavab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soalid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_javabs", x => x.javabid);
                    table.ForeignKey(
                        name: "FK_javabs_Soals_soalid",
                        column: x => x.soalid,
                        principalTable: "Soals",
                        principalColumn: "soalid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_javabs_soalid",
                table: "javabs",
                column: "soalid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "javabs");
        }
    }
}
