﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_filmscore.Migrations
{
    /// <inheritdoc />
    public partial class TabelaFilmes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Título = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gênero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diretor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Sinopse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapaFilme = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
