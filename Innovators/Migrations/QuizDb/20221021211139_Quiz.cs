using Microsoft.EntityFrameworkCore.Migrations;

namespace Innovators.Migrations.QuizDb
{
    public partial class Quiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Excecise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    Memo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memo3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memo4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memo5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.QuizId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quiz");
        }
    }
}
