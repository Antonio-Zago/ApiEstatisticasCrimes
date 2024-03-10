using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEstatisticasCrimes.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoTipoBens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "TipoBens",
                columns: table => new
                {
                    TipoBemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoBens", x => x.TipoBemId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AssaltoTipoBem",
                columns: table => new
                {
                    AssaltoId = table.Column<int>(type: "int", nullable: false),
                    TipoBemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssaltoTipoBem", x => new { x.AssaltoId, x.TipoBemId });
                    table.ForeignKey(
                        name: "FK_AssaltoTipoBem_Assaltos_AssaltoId",
                        column: x => x.AssaltoId,
                        principalTable: "Assaltos",
                        principalColumn: "AssaltoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssaltoTipoBem_TipoBens_TipoBemId",
                        column: x => x.TipoBemId,
                        principalTable: "TipoBens",
                        principalColumn: "TipoBemId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RouboTipoBem",
                columns: table => new
                {
                    RouboId = table.Column<int>(type: "int", nullable: false),
                    TipoBemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouboTipoBem", x => new { x.RouboId, x.TipoBemId });
                    table.ForeignKey(
                        name: "FK_RouboTipoBem_Roubos_RouboId",
                        column: x => x.RouboId,
                        principalTable: "Roubos",
                        principalColumn: "RouboId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouboTipoBem_TipoBens_TipoBemId",
                        column: x => x.TipoBemId,
                        principalTable: "TipoBens",
                        principalColumn: "TipoBemId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AssaltoTipoBem_TipoBemId",
                table: "AssaltoTipoBem",
                column: "TipoBemId");

            migrationBuilder.CreateIndex(
                name: "IX_AssaltoTipoBem_AssaltoId",
                table: "AssaltoTipoBem",
                column: "AssaltoId");

            migrationBuilder.CreateIndex(
                name: "IX_RouboTipoBem_TipoBemId",
                table: "RouboTipoBem",
                column: "TipoBemId");

            migrationBuilder.CreateIndex(
                name: "IX_RouboTipoBem_RouboId",
                table: "RouboTipoBem",
                column: "RouboId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "AssaltoTipoBem");

            migrationBuilder.DropTable(
                name: "RouboTipoBem");

            migrationBuilder.DropTable(
                name: "TipoBens");
        }
    }
}
