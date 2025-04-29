using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisMed.Migrations
{
    /// <inheritdoc />
    public partial class EntidadeMonitoramento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonitoramentoPaciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PressaoArterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperatura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaturacaoOxigenio = table.Column<int>(type: "int", nullable: false),
                    FrequenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    DataAfericao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitoramentoPaciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitoramentoPaciente_Pacientes_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonitoramentoPaciente_IdPaciente",
                table: "MonitoramentoPaciente",
                column: "IdPaciente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonitoramentoPaciente");
        }
    }
}
