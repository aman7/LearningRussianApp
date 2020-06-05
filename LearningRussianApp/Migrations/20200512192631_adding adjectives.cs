using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningRussianApp.Migrations
{
    public partial class addingadjectives : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adjectives",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    engWord = table.Column<string>(nullable: true),
                    russWord = table.Column<string>(nullable: true),
                    mas = table.Column<string>(nullable: true),
                    fem = table.Column<string>(nullable: true),
                    neu = table.Column<string>(nullable: true),
                    plu = table.Column<string>(nullable: true),
                    answer = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    reviewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adjectives", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adjectives_russWord",
                table: "Adjectives",
                column: "russWord",
                unique: true,
                filter: "[russWord] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adjectives");
        }
    }
}
