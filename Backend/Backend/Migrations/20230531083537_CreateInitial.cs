using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategorianev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "teszt",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kerdes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    v1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    v2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    v3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    v4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    helyes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teszt", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kategoria");

            migrationBuilder.DropTable(
                name: "teszt");
        }
    }
}
