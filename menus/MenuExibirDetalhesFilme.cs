using FilmScore.Modelos.Modelos;
using FilmScore.Shared.Data.Banco;
namespace FilmScore.Menus;

internal class MenuExibirDetalhesFilme : Menu
{
    public override void Executar(DAL<Filme> filmeDAL)
    {
        base.Executar(filmeDAL);
        ExibirTituloDaOpção("Exibir Detalhes do Filme ");
        Console.Write("Digite o nome do filme: ");
        string nomeFilme = Console.ReadLine()!;
        var filmeRecuperado = filmeDAL.RecuperarPor(f => f.Título.Equals(nomeFilme));
        Console.Clear();

        if (filmeRecuperado is not null)
        {
            Filme filme = filmeRecuperado;
            filme.ExibirFichaFilme();
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