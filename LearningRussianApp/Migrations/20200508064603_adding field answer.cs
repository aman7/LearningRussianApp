using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningRussianApp.Migrations
{
    public partial class addingfieldanswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "answer",
                table: "verbs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "answer",
                table: "nouns",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "answer",
                table: "verbs");

            migrationBuilder.DropColumn(
                name: "answer",
                table: "nouns");
        }
    }
}
