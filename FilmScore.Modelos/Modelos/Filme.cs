namespace FilmScore.Modelos.Modelos;

public class Filme
{

    public int Id { get; set; }
    public string Título { get; set; }
    public string Gênero { get; set; }
    public string Diretor { get; set; }
    public int Ano { get; set; }
    public string Sinopse { get; set; }
    public string? CapaFilme { get; set; }

    public Filme(string titulo, string gênero, string diretor,int anoLancamento, string sinopse)
    {
        Título = titulo;
        Gênero = gênero;
        Diretor = diretor;
        Ano = anoLancamento;
        Sinopse = sinopse;
        CapaFilme = "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png";

    }

    public Filme()
    {
        
    }

    public void ExibirFichaFilme()
    {
        Console.WriteLine($"******Ficha Completa******");
        Console.WriteLine($"\n**Nome do filme: {Título}");
        Console.WriteLine($"**Gênero: {Gênero}");
        Console.WriteLine($"**Diretor: {Diretor}");
        Console.WriteLine($"**Lançamento: {Ano}");
        Console.WriteLine($"**Sinopse: {Sinopse}");
    }
}