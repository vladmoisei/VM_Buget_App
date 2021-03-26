using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugetApi.Migrations
{
    public partial class AddEntitiesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departaments",
                columns: table => new
                {
                    DepartamentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Denumire = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true),
                    NumeUtilizator = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departaments", x => x.DepartamentId);
                });

            migrationBuilder.CreateTable(
                name: "Cheltuialas",
                columns: table => new
                {
                    CheltuialaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumeUtilizator = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true),
                    DepartamentId = table.Column<int>(type: "INTEGER", nullable: true),
                    Denumire = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true),
                    Suma = table.Column<int>(type: "INTEGER", nullable: false),
                    IsCheltuialaObligatorie = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsCheltuit = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheltuialas", x => x.CheltuialaId);
                    table.ForeignKey(
                        name: "FK_Cheltuialas_Departaments_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departaments",
                        principalColumn: "DepartamentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cheltuialas_DepartamentId",
                table: "Cheltuialas",
                column: "DepartamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cheltuialas");

            migrationBuilder.DropTable(
                name: "Departaments");
        }
    }
}
