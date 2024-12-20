namespace FilmScore.Modelos;
    
internal class Gênero
{
    private List<Filme> filmes =  new List<Filme>();

    public Gênero(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public void AdicionarFilmeAoGênero(Filme filme)
    {
        filmes.Add(filme);
    }
    public void ExibirFilmesDoGenero()
    {
        Console.WriteLine($"****Lista de filmes do gênero {Nome}:");
        foreach (var filme in filmes)
        {
            Console.WriteLine($"-{filme.Nome}");
        }
    }
}