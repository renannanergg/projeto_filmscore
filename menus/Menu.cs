using FilmScore.Modelos;
using projeto_filmscore.Banco;
namespace FilmScore.Menus;

internal class Menu
{
    public void ExibirTituloDaOpção(string titulo)
    {
        int qntdLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qntdLetras,'*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(DAL<Filme> filmeDAL)
    {
        Console.Clear();
    }
}