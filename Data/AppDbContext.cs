using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITeste.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Produto>()
                .Property(p => p.nome)
                    .HasMaxLength(100);

            modelBuilder.Entity<Produto>()
                .Property(p => p.descricao)
                    .HasMaxLength(100);

            modelBuilder.Entity<Produto>()
                .Property(p => p.modelo)
                    .HasMaxLength(100);

            modelBuilder.Entity<Produto>()
             
                .HasData(
                    new Produto { id = 1, nome = "Camisa Casual", modelo = "Masculino", descricao = "Camisa feita de alfaiataria nacional", quantidade = 10, tamanho = 'M' },
                    new Produto { id = 2, nome = "Bermuda Casual", modelo = "Masculino", descricao = "Bermuda feita de alfaiataria nacional", quantidade = 5, tamanho = 'P' }
                );
        }

    }
}
