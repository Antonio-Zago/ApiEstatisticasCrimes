using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEstatisticasCrimes.Migrations
{
    /// <inheritdoc />
    public partial class MudancaNomeTabelaTipoArmas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoArma",
                table: "TipoArma");

            migrationBuilder.RenameTable(
                name: "TipoArma",
                newName: "TipoArmas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoArmas",
                table: "TipoArmas",
                column: "TipoArmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assaltos_TipoArmas_TipoArmaId",
                table: "Assaltos",
                column: "TipoArmaId",
                principalTable: "TipoArmas",
                principalColumn: "TipoArmaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assaltos_TipoArmas_TipoArmaId",
                table: "Assaltos");

            migrationBuilder.DropIndex(
                name: "IX_Agressoes_OcorrenciaId",
                table: "Agressoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoArmas",
                table: "TipoArmas");

            migrationBuilder.RenameTable(
                name: "TipoArmas",
                newName: "TipoArma");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoArma",
                table: "TipoArma",
                column: "TipoArmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Agressoes_OcorrenciaId",
                table: "Agressoes",
                column: "OcorrenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assaltos_TipoArma_TipoArmaId",
                table: "Assaltos",
                column: "TipoArmaId",
                principalTable: "TipoArma",
                principalColumn: "TipoArmaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
