using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEstatisticasCrimes.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoLocalizacaoOcorrenciaUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocorrencias_LocalizacaoOcorrencia_LocalizacaoOcorrenciaId",
                table: "Ocorrencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocalizacaoOcorrencia",
                table: "LocalizacaoOcorrencia");

            migrationBuilder.RenameTable(
                name: "LocalizacaoOcorrencia",
                newName: "LocalizacaoOcorrencias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocalizacaoOcorrencias",
                table: "LocalizacaoOcorrencias",
                column: "LocalizacaoOcorrenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocorrencias_LocalizacaoOcorrencias_LocalizacaoOcorrenciaId",
                table: "Ocorrencias",
                column: "LocalizacaoOcorrenciaId",
                principalTable: "LocalizacaoOcorrencias",
                principalColumn: "LocalizacaoOcorrenciaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocorrencias_LocalizacaoOcorrencias_LocalizacaoOcorrenciaId",
                table: "Ocorrencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocalizacaoOcorrencias",
                table: "LocalizacaoOcorrencias");

            migrationBuilder.RenameTable(
                name: "LocalizacaoOcorrencias",
                newName: "LocalizacaoOcorrencia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocalizacaoOcorrencia",
                table: "LocalizacaoOcorrencia",
                column: "LocalizacaoOcorrenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocorrencias_LocalizacaoOcorrencia_LocalizacaoOcorrenciaId",
                table: "Ocorrencias",
                column: "LocalizacaoOcorrenciaId",
                principalTable: "LocalizacaoOcorrencia",
                principalColumn: "LocalizacaoOcorrenciaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
