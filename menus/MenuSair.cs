using FilmScore.Modelos;
using projeto_filmscore.Banco;
namespace FilmScore.Menus;

internal class MenuSair : Menu
{
    public override void Executar(DAL<Filme> filmeDAL)
    {
        Console.WriteLine ("Até Logo !");
    }
}