namespace FilmScore.Modelos;

internal class Diretor
{
    private List<Filme> filmesDoDiretor = new List<Filme>();
    public Diretor(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    
    public void AdicionarFilmesDoDiretor(Filme filme)
    {
        filmesDoDiretor.Add(filme);
        Console.WriteLine($"Filme {filme.Nome} adicionado a lista do diretor {Nome}");
    }
    public void ExibirFilmesDoDiretor()
    {
        Console.WriteLine($"{Nome} dirigiu os filmes: ");
        foreach (var filme in filmesDoDiretor)
        {
            Console.WriteLine($"-{filme.Nome} no ano de {filme.Ano}");
        }
    }
}