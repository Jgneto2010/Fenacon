using Domain.Entidades;
using Infra.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contextos
{
    public class Contexto : DbContext
    {
        public Contexto() {}
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Supervisor> Supervisor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new SupervisorMapping());
            modelBuilder.ApplyConfiguration(new GerenteMapping());
            modelBuilder.ApplyConfiguration(new FuncionarioMapping());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}

