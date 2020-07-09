using Domain.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra._1_Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
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
                  .HasColumnType("varchar")
                  .IsRequired();

            builder.Property(e => e.Password)
                  .HasColumnName("Password")
                   .HasColumnType("varchar")
                   .IsRequired();


            builder.Property(e => e.ConfirmPassword)
                   .HasColumnName("ConfirmPassword")
                   .HasColumnType("varchar")
                   .IsRequired();

            
        }
    }
}
