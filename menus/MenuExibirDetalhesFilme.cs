using FilmScore.Modelos;
namespace FilmScore.Menus;

internal class MenuExibirDetalhesFilme : Menu
{
    public override void Executar(Dictionary<string, Filme> filmesRegistrados)
    {
        base.Executar(filmesRegistrados);
        ExibirTituloDaOpção("Exibir Detalhes do Filme ");
        Console.Write("Digite o nome do filme: ");
        string nomeFilme = Console.ReadLine()!;
        Console.Clear();

        if (filmesRegistrados.ContainsKey(nomeFilme))
        {
            Filme filme = filmesRegistrados[nomeFilme];
            filme.ExibirFichaFilme();
            Console.WriteLine($"**A média do filme {nomeFilme} é: {filme.Media}");
            Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"O filme {nomeFilme} não foi encontrado no nosso catálogo");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }

    }
}