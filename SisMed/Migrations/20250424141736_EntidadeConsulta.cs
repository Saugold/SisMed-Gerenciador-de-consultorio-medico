using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisMed.Migrations
{
    /// <inheritdoc />
    public partial class EntidadeConsulta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Temperatura",
                table: "MonitoramentoPaciente",
                type: "DECIMAL(3,1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<byte>(
                name: "SaturacaoOxigenio",
                table: "MonitoramentoPaciente",
                type: "TINYINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PressaoArterial",
                table: "MonitoramentoPaciente",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte>(
                name: "FrequenciaCardiaca",
                table: "MonitoramentoPaciente",
                type: "TINYINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MedicamentosEmUso",
                table: "InformacoesComplementaresPaciente",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CirurgiasRealizadas",
                table: "InformacoesComplementaresPaciente",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alergias",
                table: "InformacoesComplementaresPaciente",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    IdMedico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultas_Medicos_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Pacientes_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_IdMedico",
                table: "Consultas",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_IdPaciente",
                table: "Consultas",
                column: "IdPaciente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.AlterColumn<decimal>(
                name: "Temperatura",
                table: "MonitoramentoPaciente",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(3,1)");

            migrationBuilder.AlterColumn<int>(
                name: "SaturacaoOxigenio",
                table: "MonitoramentoPaciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "TINYINT");

            migrationBuilder.AlterColumn<string>(
                name: "PressaoArterial",
                table: "MonitoramentoPaciente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "FrequenciaCardiaca",
                table: "MonitoramentoPaciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "TINYINT");

            migrationBuilder.AlterColumn<string>(
                name: "MedicamentosEmUso",
                table: "InformacoesComplementaresPaciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CirurgiasRealizadas",
                table: "InformacoesComplementaresPaciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alergias",
                table: "InformacoesComplementaresPaciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
