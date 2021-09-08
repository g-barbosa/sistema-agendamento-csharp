using GerenciamentoSalao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace GerenciamentoSalao.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                    entry.Property("Ativo").CurrentValue = true;
                    entry.Property("Id").CurrentValue = Guid.NewGuid();
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                    entry.Property("Ativo").IsModified = false;
                    entry.Property("Id").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GerenciamentoSalao;Data Source=GIO";//Environment.GetEnvironmentVariable("connectionString");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
