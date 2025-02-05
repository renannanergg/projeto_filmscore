using FilmScore.Modelos.Modelos;
using FilmScore.Shared.Data.Banco;
namespace FilmScore.Menus;

internal class MenuRegistrarFilme : Menu
{
  
    public override void Executar(DAL<Filme> filmeDAL)
    {
        base.Executar(filmeDAL);
        ExibirTituloDaOpção("Registro de filmes");

        Console.Write("\nQual o nome do filme: ");
        string nomeFilme = Console.ReadLine()!;

        Console.Write("Qual o gênero do filme: ");
        string gêneroFilme = Console.ReadLine()!;

        Console.Write("Quem é o diretor do filme: ");
        string nomeDiretor = Console.ReadLine()!;

        Console.Write("Em que ano foi lançado: ");
        string anoLancamento = Console.ReadLine()!;
        int ano = int.Parse(anoLancamento);

        Console.WriteLine("Conte um pouco sobre o filme: ");
        string sinopse = Console.ReadLine()!;

        Filme filme = new Filme(nomeFilme, gêneroFilme, nomeDiretor, ano, sinopse);

        filmeDAL.Adicionar(filme);
        Console.WriteLine($"O filme {nomeFilme} foi registrado com sucesso !");
        Thread.Sleep(2000);
        Console.Clear();
    }
}