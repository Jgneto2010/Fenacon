using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mapeamentos
{
    public class FuncionarioMapping : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
                   .IsRequired();

            builder.Property(e => e.Nome)
                   .HasColumnName("Name_User")
                   .HasColumnType("varchar(40)")
                   .IsRequired();

            builder.Property(e => e.Cpf)
                  .HasColumnName("Cpf")
                  .HasColumnType("varchar(11)")
                  .IsRequired();

            builder.Property(e => e.Endereco)
                 .HasColumnName("Address")
                 .HasColumnType("varchar(80)")
                 .IsRequired();

            builder.Property(e => e.Cargo)
                  .HasColumnName("Office")
                   .HasColumnType("Int")
                   .IsRequired();
            
            builder.Property(e => e.FeriasVencida)
                 .HasColumnName("FeriasVencidas")
                  .HasColumnType("bit");
                  

            builder.Property(e => e.CargaHoraria)
                   .HasColumnName("workload")
                   .HasColumnType("datetime")
                   .IsRequired();

            builder.Property(e => e.DataAdmissao)
                   .HasColumnName("AdmissionDate")
                   .HasColumnType("datetime")
                   .IsRequired();

            builder.Property(e => e.Situacao)
                   .HasColumnName("Situation")
                   .HasColumnType("Int")
                   .IsRequired();

            builder.HasOne(c => c.Supervisor)
                   .WithMany(c => c.Funcionarios)
                   .HasForeignKey(c => c.IdSupervisor);
                   
                 
                
        }
    }
}
