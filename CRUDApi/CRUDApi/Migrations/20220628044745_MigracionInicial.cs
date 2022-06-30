using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDApi.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlumnosItem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    primerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    segundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<int>(type: "int", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    curp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sueldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    idestadoorigen = table.Column<int>(type: "int", nullable: false),
                    idEstatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumnosItem", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlumnosItem");
        }
    }
}
