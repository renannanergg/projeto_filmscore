using FilmScore.Modelos;
namespace FilmScore.Menus;


internal class MenuRegistrarFilme : Menu
{
   
    public override void Executar(Dictionary<string, Filme> filmesRegistrados)
    {
        base.Executar(filmesRegistrados);
        ExibirTituloDaOpção("Registro de filmes");

        Console.Write("\nDigite o nome do filme: ");
        string nomeFilme = Console.ReadLine()!;

        Console.Write("Digite o gênero do filme: ");
        string gêneroFilme = Console.ReadLine()!;

        Console.Write("Quantos atores o filme tem: ");
        string atores = Console.ReadLine()!;
        int numeroAtores = int.Parse(atores);
        Elenco elenco = new Elenco();
        while (numeroAtores > 0)
        {
            Console.Write("Nome do ator: ");
            string nomeAtor = Console.ReadLine()!;
            Ator ator = new Ator(nomeAtor);
            elenco.AdicionarElenco(ator);
            numeroAtores -= 1;
        }
        Console.Write("Digite o nome do diretor do filme: ");
        string nomeDiretor = Console.ReadLine()!;
        Diretor diretor = new Diretor(nomeDiretor);

        Console.Write("Digite o ano de lançamento do filme: ");
        string anoLancamento = Console.ReadLine()!;
        int ano = int.Parse(anoLancamento);

        Console.WriteLine("Fale sobre a sinopse do filme: ");
        string sinopse = Console.ReadLine()!;
        
        Gênero gênero = new Gênero(gêneroFilme);
        Filme filme = new Filme(nomeFilme,gênero,elenco,diretor,ano)
        {
            SinopseFilme = sinopse,
        };

        filmesRegistrados.Add(nomeFilme, filme);
        Console.WriteLine($"O filme {nomeFilme} foi registrado com sucesso !");
        filme.Disponivel = true;
        Thread.Sleep(2000);
        Console.Clear();
    }
}