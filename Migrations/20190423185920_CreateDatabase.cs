using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HockeyPlayoffs.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayoffPossibilities",
                columns: table => new
                {
                    PlayoffPossibilityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Central1Winner = table.Column<string>(nullable: true),
                    Central1Games = table.Column<int>(nullable: false),
                    Central2Winner = table.Column<string>(nullable: true),
                    Central2Games = table.Column<int>(nullable: false),
                    Pacific1Winner = table.Column<string>(nullable: true),
                    Pacific1Games = table.Column<int>(nullable: false),
                    Pacific2Winner = table.Column<string>(nullable: true),
                    Pacific2Games = table.Column<int>(nullable: false),
                    Atlantic1Winner = table.Column<string>(nullable: true),
                    Atlantic1Games = table.Column<int>(nullable: false),
                    Atlantic2Winner = table.Column<string>(nullable: true),
                    Atlantic2Games = table.Column<int>(nullable: false),
                    Metro1Winner = table.Column<string>(nullable: true),
                    Metro1Games = table.Column<int>(nullable: false),
                    Metro2Winner = table.Column<string>(nullable: true),
                    Metro2Games = table.Column<int>(nullable: false),
                    CentralWinner = table.Column<string>(nullable: true),
                    CentralGames = table.Column<int>(nullable: false),
                    PacificWinner = table.Column<string>(nullable: true),
                    PacificGames = table.Column<int>(nullable: false),
                    AtlanticWinner = table.Column<string>(nullable: true),
                    AtlanticGames = table.Column<int>(nullable: false),
                    MetroWinner = table.Column<string>(nullable: true),
                    MetroGames = table.Column<int>(nullable: false),
                    WesternWinner = table.Column<string>(nullable: true),
                    WesternGames = table.Column<int>(nullable: false),
                    EasternWinner = table.Column<string>(nullable: true),
                    EasternGames = table.Column<int>(nullable: false),
                    ChampionshipsWinner = table.Column<string>(nullable: true),
                    ChampionshipsGames = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayoffPossibilities", x => x.PlayoffPossibilityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayoffPossibilities");
        }
    }
}
