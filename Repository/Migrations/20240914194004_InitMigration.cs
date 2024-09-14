using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especie = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    SomEmite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeriodoDoDia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alimentacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animais");
        }
    }
}
