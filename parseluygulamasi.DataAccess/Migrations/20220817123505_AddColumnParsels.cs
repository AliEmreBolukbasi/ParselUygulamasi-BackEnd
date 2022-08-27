using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace parseluygulamasiDataAccess.Migrations
{
    public partial class AddColumnParsels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<string>(
                name: "ilce",
                table: "Parsels",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ilce",
                table: "Parsels");

            migrationBuilder.CreateTable(
                name: "Class1x",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Il = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Sehir = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Ulke = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class1x", x => x.Id);
                });
        }
    }
}
