using ApiEstatisticasCrimes.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEstatisticasCrimes.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
               
        }

        public DbSet<Ocorrencia> Ocorrencias { get; set; }

        public DbSet<Assalto> Assaltos { get; set; }

        public DbSet<Roubo> Roubos { get; set; }

        public DbSet<Agressao> Agressoes { get; set; }

        public DbSet<TipoBem> TipoBens { get; set; }

        public DbSet<LocalizacaoOcorrencia> LocalizacaoOcorrencias { get; set; }

        public DbSet<IndiceFurto> IndiceFurtos { get; set; }

        public DbSet<IndiceAssalto> IndiceAssaltos { get; set; }

        public DbSet<IndiceAgressao> IndiceAgressao { get; set; }

        public DbSet<Zona> Zonas { get; set; }




        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Ocorrencia>().Property(e => e.TipoOcorrencia).HasConversion<int>();
        }
    }
}
