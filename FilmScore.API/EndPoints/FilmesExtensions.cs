using FilmScore.API.Requests;
using FilmScore.API.Response;
using FilmScore.Modelos.Modelos;
using Microsoft.AspNetCore.Mvc;
using FilmScore.Shared.Data.Banco;

namespace FilmScore.API.EndPoints
{
    public static class FilmesExtensions
    {
        public static void AddEndPointsFilmes(this WebApplication app)
        {
            app.MapGet("/Filmes", ([FromServices] DAL<Filme> dal) =>
            {
                return Results.Ok(dal.Listar());
            });

            app.MapGet("/Filmes/Titulo/{titulo}", ([FromServices] DAL<Filme> dal, string titulo) =>
            {
                var filme = dal.RecuperarPor(f => f.Título.ToUpper().Equals(titulo.ToUpper()));
                if (filme is null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(filme);

            });

            app.MapPost("/Filmes", ([FromServices] DAL<Filme> dal, [FromBody] FilmeRequest filmeRequest) =>
            {
                var filme = new Filme(filmeRequest.Titulo, filmeRequest.Genero, filmeRequest.Diretor, filmeRequest.Ano, filmeRequest.Sinopse);
                dal.Adicionar(filme);
                return Results.Ok();

            });

            app.MapDelete("/Filmes/{id}", ([FromServices] DAL<Filme> dal, int id) =>
            {
                var filme = dal.RecuperarPor(f => f.Id == id);
                if (filme is null)
                {
                    return Results.NotFound();
                }

                dal.Deletar(filme);
                return Results.NoContent();
            });

            app.MapPut("/Filmes", ([FromServices] DAL<Filme> dal, [FromBody] Filme filme) =>
            {
                var filmeAAtualizar = dal.RecuperarPor(f => f.Id == filme.Id);
                if (filmeAAtualizar is null)
                {
                    return Results.NotFound();
                }
                filmeAAtualizar.Título = filme.Título;
                filmeAAtualizar.Gênero = filme.Gênero;
                filmeAAtualizar.Diretor = filme.Diretor;
                filmeAAtualizar.Ano = filme.Ano;
                filmeAAtualizar.Sinopse = filme.Sinopse;
                filmeAAtualizar.CapaFilme = filme.CapaFilme;

                dal.Atualizar(filmeAAtualizar);
                return Results.Ok();
            });

            app.MapGet("/Filmes/Genero/{genero}", ([FromServices] DAL<Filme> dal, string genero) =>
            {
                var listaFilmes = dal.ListarPor(f => f.Gênero.ToUpper().Equals(genero.ToUpper()));
                if (listaFilmes is null || !listaFilmes.Any())
                {
                    return Results.NotFound();
                }
                return Results.Ok(listaFilmes);
            });

            app.MapGet("/Filmes/Lancamento/{ano}", ([FromServices] DAL<Filme> dal, int ano) =>
            {
                var listaFilmes = dal.ListarPor(f => f.Ano == ano);
                if (listaFilmes is null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(listaFilmes);
            });

            app.MapGet("/Filmes/Diretor/{diretor}", ([FromServices] DAL<Filme> dal, string diretor) =>
            {
                var filmesDoDiretor = dal.ListarPor(f => f.Diretor.ToUpper().Equals(diretor.ToUpper()));
                if (filmesDoDiretor is null || !filmesDoDiretor.Any())
                {
                    return Results.NotFound();
                }
                return Results.Ok(filmesDoDiretor);
            });
        }

        private static ICollection<FilmeResponse> EntityListToResponseList(IEnumerable<Filme> listaDeFilmes)
        {
            return listaDeFilmes.Select(a => EntityToResponse(a)).ToList();
        }

        private static FilmeResponse EntityToResponse(Filme filme)
        {
            return new FilmeResponse(filme.Título, filme.Gênero, filme.Diretor, filme.Ano, filme.Sinopse);
        }
    }
}
