namespace FilmScore.Modelos;

internal class Ator
{
    public Ator(string nome)
    {
        Nome = nome;
        FilmesAtuados = new List<Filme>();
    }

    public string Nome {get;}
    public List<Filme> FilmesAtuados { get; set; }

    public int QuantidadeDeFilmes => FilmesAtuados.Count;

    public void AdicionarFilme(Filme filme)
    {
        FilmesAtuados.Add(filme);
    }

    public void MostrarFilmesAtuados()
    {

        if (FilmesAtuados.Count == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado na base para {Nome}");

        }

        Console.WriteLine($"Filmes de {Nome}...");
        foreach (var filme in FilmesAtuados)
        {
            Console.WriteLine($"Filme: {filme.Nome}");
        }
    }

}