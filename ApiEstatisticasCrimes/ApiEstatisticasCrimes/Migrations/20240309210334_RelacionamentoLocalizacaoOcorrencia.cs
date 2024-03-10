using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEstatisticasCrimes.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoLocalizacaoOcorrencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalizacaoOcorrenciaId",
                table: "Ocorrencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LocalizacaoOcorrencia",
                columns: table => new
                {
                    LocalizacaoOcorrenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cep = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Latitude = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Longitude = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rua = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalizacaoOcorrencia", x => x.LocalizacaoOcorrenciaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencias_LocalizacaoOcorrenciaId",
                table: "Ocorrencias",
                column: "LocalizacaoOcorrenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocorrencias_LocalizacaoOcorrencia_LocalizacaoOcorrenciaId",
                table: "Ocorrencias",
                column: "LocalizacaoOcorrenciaId",
                principalTable: "LocalizacaoOcorrencia",
                principalColumn: "LocalizacaoOcorrenciaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocorrencias_LocalizacaoOcorrencia_LocalizacaoOcorrenciaId",
                table: "Ocorrencias");

            migrationBuilder.DropTable(
                name: "LocalizacaoOcorrencia");

            migrationBuilder.DropIndex(
                name: "IX_Ocorrencias_LocalizacaoOcorrenciaId",
                table: "Ocorrencias");

            migrationBuilder.DropColumn(
                name: "LocalizacaoOcorrenciaId",
                table: "Ocorrencias");
        }
    }
}
