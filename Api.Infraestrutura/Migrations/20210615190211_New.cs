using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Infraestrutura.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 20, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 20, nullable: false),
                    Endereco = table.Column<string>(maxLength: 50, nullable: false),
                    Renda = table.Column<string>(maxLength: 20, nullable: false),
                    Cpf = table.Column<string>(maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locadoras",
                columns: table => new
                {
                    IdLocadora = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnpj = table.Column<string>(maxLength: 50, nullable: false),
                    Endereco = table.Column<string>(maxLength: 11, nullable: false),
                    Cep = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locadoras", x => x.IdLocadora);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    IdCarro = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Placa = table.Column<string>(maxLength: 11, nullable: false),
                    Ano = table.Column<int>(maxLength: 11, nullable: false),
                    IdLocadora = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.IdCarro);
                    table.ForeignKey(
                        name: "FK_Carros_Locadoras_IdCarro",
                        column: x => x.IdCarro,
                        principalTable: "Locadoras",
                        principalColumn: "IdLocadora",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    IdLocacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicio = table.Column<DateTime>(maxLength: 50, nullable: false),
                    DataFim = table.Column<DateTime>(maxLength: 11, nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    LocadoraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacao", x => x.IdLocacao);
                    table.ForeignKey(
                        name: "FK_Locacao_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locacao_Locadoras_LocadoraId",
                        column: x => x.LocadoraId,
                        principalTable: "Locadoras",
                        principalColumn: "IdLocadora",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocacoesCarros",
                columns: table => new
                {
                    IdCarro = table.Column<int>(nullable: false),
                    IdLocacao = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(maxLength: 11, nullable: false),
                    DataInicio = table.Column<DateTime>(maxLength: 11, nullable: false),
                    DataFim = table.Column<DateTime>(maxLength: 11, nullable: false),
                    Renovacao = table.Column<DateTime>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocacoesCarros", x => new { x.IdCarro, x.IdLocacao });
                    table.ForeignKey(
                        name: "FK_LocacoesCarros_Carros_IdCarro",
                        column: x => x.IdCarro,
                        principalTable: "Carros",
                        principalColumn: "IdCarro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocacoesCarros_Locacao_IdLocacao",
                        column: x => x.IdLocacao,
                        principalTable: "Locacao",
                        principalColumn: "IdLocacao",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_ClienteId",
                table: "Locacao",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_LocadoraId",
                table: "Locacao",
                column: "LocadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacoesCarros_IdLocacao",
                table: "LocacoesCarros",
                column: "IdLocacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocacoesCarros");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Locadoras");
        }
    }
}
