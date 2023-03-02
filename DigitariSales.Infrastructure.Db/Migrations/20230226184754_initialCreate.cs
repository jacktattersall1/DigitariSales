using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DigitariSales.Infrastructure.Db.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DefaultLanguageId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Languages_DefaultLanguageId",
                        column: x => x.DefaultLanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageUser",
                columns: table => new
                {
                    LanguagesId = table.Column<int>(type: "integer", nullable: false),
                    UsersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageUser", x => new { x.LanguagesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_LanguageUser_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "en" },
                    { 2, "fr" },
                    { 3, "it" },
                    { 4, "de" },
                    { 5, "pl" },
                    { 6, "es" },
                    { 7, "sv" },
                    { 8, "ru" },
                    { 9, "ra" },
                    { 10, "ja" },
                    { 11, "zu" },
                    { 12, "ta" },
                    { 13, "af" },
                    { 14, "sq" },
                    { 15, "ca" },
                    { 16, "zh" },
                    { 17, "ko" },
                    { 18, "ms" },
                    { 19, "dk" },
                    { 20, "fa" },
                    { 21, "fi" },
                    { 22, "lv" },
                    { 23, "da" },
                    { 24, "nl" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DefaultLanguageId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 5 },
                    { 5, 1 },
                    { 6, 10 },
                    { 7, 15 },
                    { 8, 2 },
                    { 9, 20 },
                    { 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "LanguageUser",
                columns: new[] { "LanguagesId", "UsersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 9 },
                    { 1, 10 },
                    { 2, 3 },
                    { 2, 8 },
                    { 2, 10 },
                    { 3, 3 },
                    { 4, 3 },
                    { 4, 10 },
                    { 5, 4 },
                    { 6, 4 },
                    { 7, 4 },
                    { 8, 4 },
                    { 9, 5 },
                    { 10, 6 },
                    { 11, 6 },
                    { 12, 6 },
                    { 13, 6 },
                    { 14, 6 },
                    { 15, 7 },
                    { 16, 7 },
                    { 17, 7 },
                    { 18, 7 },
                    { 19, 8 },
                    { 20, 9 },
                    { 21, 9 },
                    { 22, 9 },
                    { 23, 10 },
                    { 24, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguageUser_UsersId",
                table: "LanguageUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DefaultLanguageId",
                table: "Users",
                column: "DefaultLanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageUser");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
