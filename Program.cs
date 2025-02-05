using FilmScore.Menus;
using FilmScore.Modelos;
using projeto_filmscore.Banco;
using projeto_filmscore.menus;

var context = new FilmScoreContext();
var filmeDAL = new DAL<Filme>(context);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarFilme());
opcoes.Add(2, new MenuExibirDetalhesFilme());
opcoes.Add(3, new MenuFilmesRegistrados());
opcoes.Add(4, new MenuExibirFilmePorAno());
opcoes.Add(5, new MenuExibirFilmePorGenero());
opcoes.Add(0, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"
███████╗██╗██╗░░░░░███╗░░░███╗░██████╗░█████╗░░█████╗░██████╗░███████╗
██╔════╝██║██║░░░░░████╗░████║██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔════╝
█████╗░░██║██║░░░░░██╔████╔██║╚█████╗░██║░░╚═╝██║░░██║██████╔╝█████╗░░
██╔══╝░░██║██║░░░░░██║╚██╔╝██║░╚═══██╗██║░░██╗██║░░██║██╔══██╗██╔══╝░░
██║░░░░░██║███████╗██║░╚═╝░██║██████╔╝╚█████╔╝╚█████╔╝██║░░██║███████╗
╚═╝░░░░░╚═╝╚══════╝╚═╝░░░░░╚═╝╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚═╝╚══════╝
");
    Console.WriteLine("             *****Bem Vindo ao FilmeScore*****            ");

}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite [1] para adicionar um filme");
    Console.WriteLine("Digite [2] para mostrar detalhes de um filme ");
    Console.WriteLine("Digite [3] para mostrar todos filmes ");
    Console.WriteLine("Digite [4] para mostrar todos filmes por ano");
    Console.WriteLine("Digite [5] para mostrar todos filmes por gênero");
    Console.WriteLine("Digite [0] para sair");
    Console.Write("\nDigite a opção: ");

    string opçãoEscolhida = Console.ReadLine()!;
    int opçãoNumerica = int.Parse(opçãoEscolhida);

    if (opcoes.ContainsKey(opçãoNumerica))
    {
        Menu menuASerExibido = opcoes[opçãoNumerica];
        menuASerExibido.Executar(filmeDAL);
        if (opçãoNumerica > 0) ExibirMenu();
    }
    else
    {
        Console.WriteLine ("Opção Inválida !");
    }
}


ExibirMenu();