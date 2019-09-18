using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Video_Game_Store_COMP2084_F19.Data.Migrations
{
    public partial class SeedDataAndcreatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(table: "Game", "Id", 1);

            migrationBuilder.DeleteData(table: "Game", "Id", 2);
            migrationBuilder.DropColumn(
                name: "Developer",
                table: "Game");

            migrationBuilder.AddColumn<int>(
                name: "DeveloperId",
                table: "Game",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Game",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Developer",
                columns: table => new
                {
                    DeveloperId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developer", x => x.DeveloperId);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                });

            migrationBuilder.InsertData(
                table: "Developer",
                columns: new[] { "DeveloperId", "City", "Name", "StreetAddress", "Telephone" },
                values: new object[,]
                {
                    { 1, "Tokyo", "Konami", "A road in Japan", "123456789" },
                    { 2, "Mexico City", "Squad", "Probably poorly defined", "0987654321" },
                    { 3, "Montreal", "Uber Entertainment", "some french road", "83798273489" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Games where you shoot things with guns", "First Person Shooters" },
                    { 2, "Pretending to be real life, but not", "Simulation" }
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "Description", "DeveloperId", "GenreId", "MinimumRequirements", "Name", "Price" },
                values: new object[] { 3, "Sneak a lot", 1, 1, "PS4", "Metal Gear Solid", 59.99m });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "Description", "DeveloperId", "GenreId", "MinimumRequirements", "Name", "Price" },
                values: new object[] { 4, "Science the shit out stuff", 2, 2, "A Computer", "Kerbal Space Program", 6.99m });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "Description", "DeveloperId", "GenreId", "MinimumRequirements", "Name", "Price" },
                values: new object[] { 5, "Science the shit out stuff, Harder", 3, 2, "A Computer", "Kerbal Space Program 2", 69.99m });

            migrationBuilder.CreateIndex(
                name: "IX_Game_DeveloperId",
                table: "Game",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_GenreId",
                table: "Game",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Developer_DeveloperId",
                table: "Game",
                column: "DeveloperId",
                principalTable: "Developer",
                principalColumn: "DeveloperId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Genre_GenreId",
                table: "Game",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Developer_DeveloperId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Game_Genre_GenreId",
                table: "Game");

            migrationBuilder.DropTable(
                name: "Developer");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Game_DeveloperId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_GenreId",
                table: "Game");

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "DeveloperId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Game");

            migrationBuilder.AddColumn<string>(
                name: "Developer",
                table: "Game",
                nullable: true);
        }
    }
}
