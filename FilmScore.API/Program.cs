using System.Text.Json.Serialization;
using FilmScore.API.EndPoints;
using FilmScore.Modelos.Modelos;
using Microsoft.EntityFrameworkCore;
using FilmScore.Shared.Data.Banco;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FilmScoreContext>((options) =>
{
    options
            .UseSqlServer(builder.Configuration["ConnectionStrings:FilmScoreDB"])
            .UseLazyLoadingProxies();
});
builder.Services.AddTransient<DAL<Filme>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

app.AddEndPointsFilmes();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
