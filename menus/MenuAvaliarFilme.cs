using FilmScore.Modelos;
namespace FilmScore.Menus;

internal class MenuAvaliarFilme : Menu
{
    public override void Executar(Dictionary<string, Filme> filmesRegistrados)
    {
        base.Executar(filmesRegistrados);
        ExibirTituloDaOpção("Avaliação de Filmes");
        Console.Write("Digite o nome do filme que deseja avaliar: ");
        string filmeAvaliado = Console.ReadLine()!;

        if (filmesRegistrados.ContainsKey(filmeAvaliado))
        {
            Filme filme = filmesRegistrados[filmeAvaliado];
            Console.Write($"Qual nota {filmeAvaliado} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            filme.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} para o filme {filmeAvaliado} foi adicionada com sucesso !");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO filme {filmeAvaliado} não foi encontrado !");
            Console.Write("Digite uma tecla para voltar ao menu: ");
            Console.ReadKey();
            Console.Clear();
        }

    }
}