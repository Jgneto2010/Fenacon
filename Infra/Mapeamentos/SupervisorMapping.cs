using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mapeamentos
{
    public class SupervisorMapping : IEntityTypeConfiguration<Supervisor>
    {
        public void Configure(EntityTypeBuilder<Supervisor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
                   .IsRequired();


            builder.Property(e => e.Nome)
                   .HasColumnName("Name")
                   .HasColumnType("varchar(40)")
                   .IsRequired();


            builder.HasMany(x => x.Funcionarios);
                   
        }
    }
}
