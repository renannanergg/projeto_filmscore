using FilmScore.Menus;
using FilmScore.Modelos;


Dictionary<string, Filme> filmesRegistrados = new();
Dictionary<int, Menu> opcoes = new();

opcoes.Add(1, new MenuRegistrarFilme());
opcoes.Add(2, new MenuAvaliarFilme());
opcoes.Add(3, new MenuExibirDetalhesFilme());
opcoes.Add(4, new MenuFilmesRegistrados());
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
    Console.WriteLine("Digite [2] para avaliar um filme");
    Console.WriteLine("Digite [3] para mostrar detalhes do filme");
    Console.WriteLine("Digite [4] para mostrar todos filmes");
    Console.WriteLine("Digite [0] para sair");
    Console.Write("\nDigite a opção: ");

    string opçãoEscolhida = Console.ReadLine()!;
    int opçãoNumerica = int.Parse(opçãoEscolhida);

    if (opcoes.ContainsKey(opçãoNumerica))
    {
        Menu menuASerExibido = opcoes[opçãoNumerica];
        menuASerExibido.Executar(filmesRegistrados);
        if (opçãoNumerica > 0) ExibirMenu();
    }
    else
    {
        Console.WriteLine ("Opção Inválida !");
    }
}


ExibirMenu();