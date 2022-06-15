using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1406HomeworkImSoTiredBruhhhhhhh.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameType = table.Column<int>(type: "int", nullable: false),
                    GameStudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Multiplayer = table.Column<bool>(type: "bit", nullable: false),
                    SoldCopies = table.Column<int>(type: "int", nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
