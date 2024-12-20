using FilmScore.Modelos;
namespace FilmScore.Menus;

internal class MenuFilmesRegistrados : Menu
{
    public override void Executar(Dictionary<string, Filme> filmesRegistrados)
    {
        base.Executar(filmesRegistrados);
        ExibirTituloDaOpção("Exibir Filmes Registrados");
        Console.WriteLine($"\nExistem {Filme.ContadorDeFilme} filme(s) registrados: ");
        foreach (string filme in filmesRegistrados.Keys)
        {
            Console.WriteLine($"-{filme}");
        }
        Console.Write("\nDigite qualquer tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
    }
}