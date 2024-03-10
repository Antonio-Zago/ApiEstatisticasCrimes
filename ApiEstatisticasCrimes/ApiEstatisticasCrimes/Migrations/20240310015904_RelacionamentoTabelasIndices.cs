using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEstatisticasCrimes.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoTabelasIndices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zonas",
                columns: table => new
                {
                    ZonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LatitudeCentral = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LongitudeCentral = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Raio = table.Column<double>(type: "double", nullable: false),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonas", x => x.ZonaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IndiceAgressao",
                columns: table => new
                {
                    IndiceAgressaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAgendamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IndiceAgressaoValor = table.Column<double>(type: "double", nullable: false),
                    ZonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndiceAgressao", x => x.IndiceAgressaoId);
                    table.ForeignKey(
                        name: "FK_IndiceAgressao_Zonas_ZonaId",
                        column: x => x.ZonaId,
                        principalTable: "Zonas",
                        principalColumn: "ZonaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IndiceAssaltos",
                columns: table => new
                {
                    IndiceAssaltoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAgendamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IndiceAssaltoValor = table.Column<double>(type: "double", nullable: false),
                    ZonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndiceAssaltos", x => x.IndiceAssaltoId);
                    table.ForeignKey(
                        name: "FK_IndiceAssaltos_Zonas_ZonaId",
                        column: x => x.ZonaId,
                        principalTable: "Zonas",
                        principalColumn: "ZonaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IndiceFurtos",
                columns: table => new
                {
                    IndiceFurtoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAgendamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IndiceFurtoValor = table.Column<double>(type: "double", nullable: false),
                    ZonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndiceFurtos", x => x.IndiceFurtoId);
                    table.ForeignKey(
                        name: "FK_IndiceFurtos_Zonas_ZonaId",
                        column: x => x.ZonaId,
                        principalTable: "Zonas",
                        principalColumn: "ZonaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_IndiceAgressao_ZonaId",
                table: "IndiceAgressao",
                column: "ZonaId");

            migrationBuilder.CreateIndex(
                name: "IX_IndiceAssaltos_ZonaId",
                table: "IndiceAssaltos",
                column: "ZonaId");

            migrationBuilder.CreateIndex(
                name: "IX_IndiceFurtos_ZonaId",
                table: "IndiceFurtos",
                column: "ZonaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndiceAgressao");

            migrationBuilder.DropTable(
                name: "IndiceAssaltos");

            migrationBuilder.DropTable(
                name: "IndiceFurtos");

            migrationBuilder.DropTable(
                name: "Zonas");
        }
    }
}
