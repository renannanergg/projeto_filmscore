using FilmScore.Modelos;
using projeto_filmscore.Banco;
namespace FilmScore.Menus;

internal class MenuFilmesRegistrados : Menu
{
    public override void Executar(DAL<Filme> filmeDAL)
    {
        base.Executar(filmeDAL);
        ExibirTituloDaOpção("Exibir Filmes Registrados");
        foreach (var filme in filmeDAL.Listar())
        {
            Console.WriteLine($"-{filme.Título} | {filme.Gênero} | {filme.Ano}");
        }
        Console.Write("\nDigite qualquer tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
    }
}