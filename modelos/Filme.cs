namespace FilmScore.Modelos;

internal class Filme : IAvaliavel
{
    private List<Avaliacao> notas = new ();

    public static int ContadorDeFilme = 0;
    public Filme(string nome, Gênero gênero, Elenco elenco, Diretor diretor,int ano)
    {
        Nome = nome;
        Gênero = gênero;
        Elenco = elenco;
        Diretor = diretor;
        Ano = ano;

        ContadorDeFilme ++;
    }

    public string Nome { get;}
    public Gênero Gênero { get; }
    public Diretor Diretor { get; set; }
    public bool Disponivel { get; set; }
    public int Ano {get; }
    public Elenco Elenco {get; set; }
    public string? SinopseFilme { get; set;}

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
    public void ExibirNotas()
    {
        Console.WriteLine($"Notas do filme {Nome}");
        foreach (var nota in notas)
        {
            Console.WriteLine($"-{nota}");
        }
    }
    public void ExibirFichaFilme()
    {
        Console.WriteLine($"******Ficha Completa******");
        Console.WriteLine($"\n**Nome do filme: {Nome}");
        Console.WriteLine($"**Gênero: {Gênero.Nome}");
        Console.WriteLine($"**Diretor: {Diretor.Nome}");
        Console.WriteLine($"**Lançamento: {Ano}");
        Console.WriteLine($"**Sinopse: {SinopseFilme}");
        Elenco.ExibirElenco();
        if (Disponivel)
        {
            Console.WriteLine("**Status: Dísponivel na plataforma");
        }
        else
        {
            Console.WriteLine($"**Status: Indisponível");
        }
    }
}