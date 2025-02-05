using FilmScore.Modelos.Modelos;
using FilmScore.Shared.Data.Banco;
namespace FilmScore.Menus;

internal class MenuSair : Menu
{
    public override void Executar(DAL<Filme> filmeDAL)
    {
        Console.WriteLine ("Até Logo !");
    }
}