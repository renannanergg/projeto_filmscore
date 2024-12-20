namespace FilmScore.Modelos;

internal class Elenco
{
    private List<Ator> Atores = new List<Ator>();

    public void AdicionarElenco(Ator ator)
    {
        Atores.Add(ator);
    }

    public void ExibirElenco()
    {
        Console.WriteLine("**Elenco: ");
        foreach (var ator in Atores)
        {
            Console.WriteLine($"-----{ator.Nome}");
        }
    }

}