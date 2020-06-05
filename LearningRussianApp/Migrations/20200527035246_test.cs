using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningRussianApp.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "testcolumn",
                table: "Adjectives",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "testcolumn",
                table: "Adjectives");
        }
    }
}
