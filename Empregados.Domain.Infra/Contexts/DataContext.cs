using Empregados.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
            
        }
        public DbSet<Empregado>  Empregados { get; set; }
        public DbSet<Empresa>  Empresas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_configuration.GetConnectionString("MySQL"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empregado>().ToTable("Empregados");
            modelBuilder.Entity<Empregado>().Property(x=> x.Id);
            modelBuilder.Entity<Empregado>().Property(x=> x.Nome);
            modelBuilder.Entity<Empregado>().Property(x=> x.Departamento);
            modelBuilder.Entity<Empregado>().Property(x=> x.Cargo);
            modelBuilder.Entity<Empregado>().Property(x=> x.Excluido).HasColumnType("bit");

            modelBuilder.Entity<Empresa>().ToTable("Empresa")                
                .HasData(new Empresa("Nome da Empresa", "Endereço da Empresa", "+55 (41) 99999-9999"));
            modelBuilder.Entity<Empresa>().Property(x => x.Nome);
            modelBuilder.Entity<Empresa>().Property(x => x.Endereco);
            modelBuilder.Entity<Empresa>().Property(x => x.Telefone);            
        }
    }
}
