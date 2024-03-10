using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEstatisticasCrimes.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoTipoArma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<bool>(
                name: "EstavaArmado",
                table: "Assaltos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TipoArmaId",
                table: "Assaltos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipoArma",
                columns: table => new
                {
                    TipoArmaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ArmaFogo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoArma", x => x.TipoArmaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Assaltos_TipoArmaId",
                table: "Assaltos",
                column: "TipoArmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assaltos_TipoArma_TipoArmaId",
                table: "Assaltos",
                column: "TipoArmaId",
                principalTable: "TipoArma",
                principalColumn: "TipoArmaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assaltos_TipoArma_TipoArmaId",
                table: "Assaltos");

            migrationBuilder.DropTable(
                name: "TipoArma");

            migrationBuilder.DropIndex(
                name: "IX_Assaltos_TipoArmaId",
                table: "Assaltos");

            migrationBuilder.DropColumn(
                name: "EstavaArmado",
                table: "Assaltos");

            migrationBuilder.DropColumn(
                name: "TipoArmaId",
                table: "Assaltos");

        }
    }
}
