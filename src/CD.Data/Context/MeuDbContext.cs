
using AppMvcBasica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos{ get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
