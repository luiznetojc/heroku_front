using GerenciadordeVendas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadordeVendas.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> Options): base(Options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Produto>().HasKey(x => x.Id);
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
