
using FilmScore.Modelos;
using projeto_filmscore.Banco;

namespace FilmScore.Menus
{
    internal class MenuExibirFilmePorGenero : Menu
    {
        public override void Executar(DAL<Filme> filmeDAL)
        {
            base.Executar(filmeDAL);
            ExibirTituloDaOpção("Mostrar filmes por gênero");
            Console.Write("Qual gênero deseja pesquisar: ");
            string genero = Console.ReadLine()!;
            var listaGeneros = filmeDAL.ListarPor(f => f.Gênero == genero);
            if (listaGeneros.Any())
            {
                Console.WriteLine($"\nFilmes de {genero}: ");
                Console.WriteLine();
                foreach (var filme in listaGeneros)
                {
                    Console.WriteLine($"{filme.Título} | {filme.Gênero} | {filme.Ano}");
                }
                Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nNenhum filme encontrado !");
                Console.Write("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}
