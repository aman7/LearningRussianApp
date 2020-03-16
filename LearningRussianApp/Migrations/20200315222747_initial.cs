using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningRussianApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nouns",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    engWord = table.Column<string>(nullable: true),
                    russWord = table.Column<string>(nullable: true),
                    r1 = table.Column<string>(nullable: true),
                    r2 = table.Column<string>(nullable: true),
                    r3 = table.Column<string>(nullable: true),
                    r4 = table.Column<string>(nullable: true),
                    r5 = table.Column<string>(nullable: true),
                    r6 = table.Column<string>(nullable: true),
                    r7 = table.Column<string>(nullable: true),
                    r8 = table.Column<string>(nullable: true),
                    r9 = table.Column<string>(nullable: true),
                    r10 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nouns", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "verbs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    engWord = table.Column<string>(nullable: true),
                    russWord = table.Column<string>(nullable: true),
                    p1 = table.Column<string>(nullable: true),
                    p2 = table.Column<string>(nullable: true),
                    p3 = table.Column<string>(nullable: true),
                    p4 = table.Column<string>(nullable: true),
                    p5 = table.Column<string>(nullable: true),
                    p6 = table.Column<string>(nullable: true),
                    ps1 = table.Column<string>(nullable: true),
                    ps2 = table.Column<string>(nullable: true),
                    ps3 = table.Column<string>(nullable: true),
                    ps4 = table.Column<string>(nullable: true),
                    f1 = table.Column<string>(nullable: true),
                    f2 = table.Column<string>(nullable: true),
                    f3 = table.Column<string>(nullable: true),
                    f4 = table.Column<string>(nullable: true),
                    f5 = table.Column<string>(nullable: true),
                    f6 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_verbs", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_nouns_russWord",
                table: "nouns",
                column: "russWord",
                unique: true,
                filter: "[russWord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_verbs_russWord",
                table: "verbs",
                column: "russWord",
                unique: true,
                filter: "[russWord] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nouns");

            migrationBuilder.DropTable(
                name: "verbs");
        }
    }
}
