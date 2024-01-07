using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbAdapter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoricoNegociacao",
                columns: table => new
                {
                    SiglaMoeda = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaiorPreco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MenorPreco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantidadeNegociada = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecoUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaiorPrecoOfertado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MenorPrecoOfertado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataHora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoNegociacao", x => x.SiglaMoeda);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoNegociacoes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SiglaMoeda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaiorPreco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MenorPreco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantidadeNegociada = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecoUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaiorPrecoOfertado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MenorPrecoOfertado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataHora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoNegociacoes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoNegociacao");

            migrationBuilder.DropTable(
                name: "HistoricoNegociacoes");
        }
    }
}
