using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using FilmScore.Modelos.Modelos;

namespace FilmScore.Shared.Data.Banco
{
    public class FilmScoreContext: DbContext
    {
        public DbSet<Filme> Filmes { get; set; }

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FilmScore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public FilmScoreContext(DbContextOptions options) : base(options)
        {

        }

        public FilmScoreContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                return;
            }
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
            
        }

    }
}

