using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEstatisticasCrimes.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoTipoDeOcorrencias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantidadeVitimas",
                table: "Assaltos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Agressoes",
                columns: table => new
                {
                    AgressaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OcorrenciaId = table.Column<int>(type: "int", nullable: false),
                    QuantidadeVitimas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agressoes", x => x.AgressaoId);
                    table.ForeignKey(
                        name: "FK_Agressoes_Ocorrencias_OcorrenciaId",
                        column: x => x.OcorrenciaId,
                        principalTable: "Ocorrencias",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roubos",
                columns: table => new
                {
                    RouboId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OcorrenciaId = table.Column<int>(type: "int", nullable: false),
                    QuantidadeVitimas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roubos", x => x.RouboId);
                    table.ForeignKey(
                        name: "FK_Roubos_Ocorrencias_OcorrenciaId",
                        column: x => x.OcorrenciaId,
                        principalTable: "Ocorrencias",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Agressoes_OcorrenciaId",
                table: "Agressoes",
                column: "OcorrenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Roubos_OcorrenciaId",
                table: "Roubos",
                column: "OcorrenciaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agressoes");

            migrationBuilder.DropTable(
                name: "Roubos");

            migrationBuilder.DropColumn(
                name: "QuantidadeVitimas",
                table: "Assaltos");
        }
    }
}
