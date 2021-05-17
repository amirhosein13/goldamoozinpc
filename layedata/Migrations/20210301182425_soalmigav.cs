using Microsoft.EntityFrameworkCore.Migrations;

namespace layedata.Migrations
{
    public partial class soalmigav : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Soals",
                columns: table => new
                {
                    soalid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soaltitr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soalmatn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zamimesoal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doreid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soals", x => x.soalid);
                    table.ForeignKey(
                        name: "FK_Soals_dores_doreid",
                        column: x => x.doreid,
                        principalTable: "dores",
                        principalColumn: "doreid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Soals_doreid",
                table: "Soals",
                column: "doreid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Soals");
        }
    }
}
