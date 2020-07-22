using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mapeamentos
{
    public class GerenteMapping : IEntityTypeConfiguration<Gerente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Gerente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
                   .IsRequired();


            builder.Property(e => e.Nome)
                   .HasColumnName("Name")
                   .HasColumnType("varchar(40)")
                   .IsRequired();
        }
    }
}
