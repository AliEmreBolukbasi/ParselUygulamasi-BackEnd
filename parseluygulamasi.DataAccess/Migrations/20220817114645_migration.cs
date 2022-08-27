using Microsoft.EntityFrameworkCore.Migrations;

namespace parseluygulamasiDataAccess.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_parsels",
                table: "parsels");

            migrationBuilder.RenameTable(
                name: "parsels",
                newName: "Parsels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parsels",
                table: "Parsels",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parsels",
                table: "Parsels");

            migrationBuilder.RenameTable(
                name: "Parsels",
                newName: "parsels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_parsels",
                table: "parsels",
                column: "Id");
        }
    }
}
