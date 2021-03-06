﻿using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mapeamentos
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
                   .HasColumnName("Id_User")
                   .HasColumnType("varchar(40)")
                   .IsRequired();


            builder.Property(e => e.Name)
                   .HasColumnName("Name_User")
                   .HasColumnType("varchar(40)")
                   .IsRequired();

            builder.Property(e => e.Login)
                  .HasColumnName("Login")
                  .HasColumnType("varchar(40)")
                  .IsRequired();

            builder.Property(e => e.Password)
                  .HasColumnName("Password")
                   .HasColumnType("varchar(40)")
                   .IsRequired();

            builder.Property(e => e.ConfirmPassword)
                   .HasColumnName("ConfirmPassword")
                   .HasColumnType("varchar(40)")
                   .IsRequired();
        }
    }
}
