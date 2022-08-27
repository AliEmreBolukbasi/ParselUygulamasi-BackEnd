using Microsoft.EntityFrameworkCore.Migrations;

namespace parseluygulamasiDataAccess.Migrations
{
    public partial class AttributeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ilcem",
                table: "Parsels");

            migrationBuilder.AlterColumn<string>(
                name: "Ulke",
                table: "Parsels",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ulke",
                table: "Parsels",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Ilcem",
                table: "Parsels",
                type: "text",
                nullable: true);
        }
    }
}
