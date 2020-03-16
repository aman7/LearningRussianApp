using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningRussianApp.Migrations
{
    public partial class addedreviewdateandstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "reviewDate",
                table: "verbs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "verbs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "reviewDate",
                table: "nouns",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "nouns",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "reviewDate",
                table: "verbs");

            migrationBuilder.DropColumn(
                name: "status",
                table: "verbs");

            migrationBuilder.DropColumn(
                name: "reviewDate",
                table: "nouns");

            migrationBuilder.DropColumn(
                name: "status",
                table: "nouns");
        }
    }
}
