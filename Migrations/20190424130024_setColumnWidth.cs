using Microsoft.EntityFrameworkCore.Migrations;

namespace HockeyPlayoffs.Migrations
{
    public partial class setColumnWidth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WesternWinner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PacificWinner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pacific2Winner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pacific1Winner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetroWinner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Metro2Winner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Metro1Winner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EasternWinner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChampionshipsWinner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CentralWinner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Central2Winner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Central1Winner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AtlanticWinner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Atlantic2Winner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Atlantic1Winner",
                table: "PlayoffPossibilities",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WesternWinner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PacificWinner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pacific2Winner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pacific1Winner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetroWinner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Metro2Winner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Metro1Winner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EasternWinner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChampionshipsWinner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CentralWinner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Central2Winner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Central1Winner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AtlanticWinner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Atlantic2Winner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Atlantic1Winner",
                table: "PlayoffPossibilities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);
        }
    }
}
