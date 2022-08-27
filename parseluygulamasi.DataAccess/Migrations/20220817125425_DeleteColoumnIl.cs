using Microsoft.EntityFrameworkCore.Migrations;

namespace parseluygulamasiDataAccess.Migrations
{
    public partial class DeleteColoumnIl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Il",
                table: "Parsels");

            migrationBuilder.RenameColumn(
                name: "ilce",
                table: "Parsels",
                newName: "Ilce");

            migrationBuilder.AlterColumn<string>(
                name: "Ilce",
                table: "Parsels",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ilce",
                table: "Parsels",
                newName: "ilce");

            migrationBuilder.AlterColumn<string>(
                name: "ilce",
                table: "Parsels",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "Parsels",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
