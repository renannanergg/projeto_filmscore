using FilmScore.Modelos;
namespace FilmScore.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Filme> filmesRegistrados)
    {
        Console.WriteLine ("Até Logo !");
    }
}