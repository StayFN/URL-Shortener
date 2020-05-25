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
                    Token = table.Column<string>(nullable: false),
                    OriginalUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlModels", x => x.Token);
                });

            migrationBuilder.InsertData(
                table: "UrlModels",
                columns: new[] { "Token", "OriginalUrl" },
                values: new object[] { "yt", "https://www.youtube.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrlModels");
        }
    }
}
