using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningRussianApp.Migrations
{
    public partial class addingcolumngender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "nouns",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "nouns");
        }
    }
}
