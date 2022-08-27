using Microsoft.EntityFrameworkCore.Migrations;

namespace parseluygulamasiDataAccess.Migrations
{
    public partial class asdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ilcem",
                table: "Parsels",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ilcem",
                table: "Parsels");
        }
    }
}
