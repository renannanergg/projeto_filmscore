using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_filmscore.Migrations
{
    /// <inheritdoc />
    public partial class InserindoDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Filmes",
                new string[] { "Título", "Gênero", "Diretor", "Ano", "Sinopse", "CapaFilme" },
                new object[] {"Corra", "Terror", "Jordan Peele", "2017", "Chris é jovem negro que está prestes a conhecer a família de sua namorada branca Rose.", "https://upload.wikimedia.org/wikipedia/pt/0/02/Get_Out_2017.png" }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
