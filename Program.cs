// FilmeScore

string mensagemDeBoasVindas = "\nBem vindo ao FilmScore";
Dictionary<string, List<int>> filmesRegistrados = new Dictionary<string, List<int>>();


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
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite [1] para adicionar um filme");
    Console.WriteLine("Digite [2] para avaliar um filme");
    Console.WriteLine("Digite [3] para mostrar todos os filmes");
    Console.WriteLine("Digite [4] para mostrar a média do filme");
    Console.WriteLine("Digite [0] para sair");
    Console.Write("\nDigite a opção: ");

    string opçãoEscolhida = Console.ReadLine()!;
    int opçãoNumerica = int.Parse(opçãoEscolhida);
    
    switch (opçãoNumerica)
    {
        case 1:
            RegistrarFilme();
            break;
        case 2:
            AvaliarFilme();
            break;
        case 3:
            MostrarFilmesRegistrados();
            break;
        case 4:
            MostrarMediaFilmes();
            break;
        case 0: 
            Console.WriteLine ("Até Logo !");
            break;
        default: 
            Console.WriteLine ("Opção Inválida !");
            break;
    }
}

void RegistrarFilme()
{   
    Console.Clear();
    ExibirTituloDaOpção("Registro de filmes");
    Console.Write("\nDigite o nome do filme: ");
    string nomeFilme = Console.ReadLine()!;
    filmesRegistrados.Add(nomeFilme, new List<int>());
    Console.WriteLine($"O filme {nomeFilme} foi registrado com sucesso !");

    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarFilmesRegistrados()
{
    Console.Clear();
    ExibirTituloDaOpção("Exibir Filmes Registrados");
    foreach (string filme in filmesRegistrados.Keys)
    {
        Console.WriteLine($"{filme}");
    }
    Console.Write("\nDigite qualquer tecla para voltar ao menu: ");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ExibirTituloDaOpção(string titulo)
{
    int qntdLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qntdLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}

void AvaliarFilme()
{
    Console.Clear();
    ExibirTituloDaOpção("Avaliação de Filmes");
    Console.Write("Digite o nome do filme que deseja avaliar: ");
    string filmeAvaliado = Console.ReadLine()!;
    if (filmesRegistrados.ContainsKey(filmeAvaliado))
    {
        Console.Write($"Qual nota {filmeAvaliado} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        filmesRegistrados[filmeAvaliado].Add(nota);
        Console.WriteLine($"\n A nota {nota} para o filme {filmeAvaliado} foi adicionada com sucesso !");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    } else
    {
        Console.WriteLine($"\nO filme {filmeAvaliado} não foi encontrado !");
        Console.Write("Digite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }

}

void MostrarMediaFilmes()
{
    Console.Clear();
    ExibirTituloDaOpção("Média do filme");
    Console.Write("Qual filme voce deseja saber a média: ");
    string filmeMedia= Console.ReadLine()!;
    if (filmesRegistrados.ContainsKey(filmeMedia))
    {
        double mediaDoFilme = filmesRegistrados[filmeMedia].Average();
        Console.WriteLine($"A média do filme {filmeMedia} é {mediaDoFilme}");
        Console.Write("Digite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
    else
    {
        Console.WriteLine($"O filme {filmeMedia} não foi encontrado !");
        Console.Write("Digite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

ExibirMenu();