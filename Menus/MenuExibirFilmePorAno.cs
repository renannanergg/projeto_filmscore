using FilmScore.Menus;
using FilmScore.Modelos;
using projeto_filmscore.Banco;

namespace projeto_filmscore.menus
{
    internal class MenuExibirFilmePorAno : Menu 
    {
        public override void Executar(DAL<Filme> filmeDAL)
        {
            base.Executar(filmeDAL);
            ExibirTituloDaOpção("Mostrar filmes por ano de lançamento");
            Console.Write("Qual ano deseja pesquisar: ");
            string stringLancamento = Console.ReadLine()!;
            int anoLancamento = int.Parse(stringLancamento);
            var listaAnoLancamento = filmeDAL.ListarPor(f => f.Ano == anoLancamento);
            if (listaAnoLancamento.Any())
            {
                Console.WriteLine($"\nFilmes lançados em {anoLancamento}: ");
                Console.WriteLine();
                foreach (var filme in listaAnoLancamento)
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
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
