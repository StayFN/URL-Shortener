using Microsoft.EntityFrameworkCore.Migrations;

namespace URL_Shortener.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UrlModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OriginalUrl = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UrlModels",
                columns: new[] { "Id", "OriginalUrl", "Token" },
                values: new object[] { 1, "https://www.youtube.com", "yt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrlModels");
        }
    }
}
