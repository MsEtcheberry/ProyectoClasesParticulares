using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoClases.Migrations
{
    public partial class ProyectoClasesParticularesContextClasesParticularesDatabaseContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    idAlumno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(maxLength: 30, nullable: false),
                    apellido = table.Column<string>(maxLength: 30, nullable: false),
                    mail = table.Column<string>(nullable: false),
                    escuela = table.Column<string>(nullable: true),
                    fechaNacimiento = table.Column<DateTime>(nullable: false),
                    grado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.idAlumno);
                });

            migrationBuilder.CreateTable(
                name: "Docente",
                columns: table => new
                {
                    idDocente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false),
                    apellido = table.Column<string>(maxLength: 30, nullable: false),
                    mail = table.Column<string>(nullable: false),
                    descripcion = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docente", x => x.idDocente);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    idMateria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false),
                    DocenteidDocente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.idMateria);
                    table.ForeignKey(
                        name: "FK_Materias_Docente_DocenteidDocente",
                        column: x => x.DocenteidDocente,
                        principalTable: "Docente",
                        principalColumn: "idDocente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    idClase = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaYHora = table.Column<DateTime>(nullable: false),
                    tema = table.Column<string>(nullable: false),
                    MateriaId = table.Column<int>(nullable: false),
                    AlumnoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.idClase);
                    table.ForeignKey(
                        name: "FK_Clases_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "idAlumno",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clases_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "idMateria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clases_AlumnoId",
                table: "Clases",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_MateriaId",
                table: "Clases",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_DocenteidDocente",
                table: "Materias",
                column: "DocenteidDocente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Docente");
        }
    }
}
