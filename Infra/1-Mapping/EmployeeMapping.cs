using Domain.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra._1_Mappimg
{
    public class EmployeeMapping : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
                   .IsRequired();


            builder.Property(e => e.Name)
                   .HasColumnName("Name_User")
                   .HasColumnType("varchar(40)")
                   .IsRequired();

            builder.Property(e => e.Cpf)
                  .HasColumnName("Cpf")
                  .HasColumnType("varchar(11)")
                  .IsRequired();

            builder.Property(e => e.Address)
                 .HasColumnName("Address")
                 .HasColumnType("varchar(80)")
                 .IsRequired();

            builder.Property(e => e.Office)
                  .HasColumnName("Office")
                   .HasColumnType("Int")
                   .IsRequired();

            builder.Property(e => e.workload)
                   .HasColumnName("workload")
                   .HasColumnType("datetime")
                   .IsRequired();

            builder.Property(e => e.AdmissionDate)
                   .HasColumnName("AdmissionDate")
                   .HasColumnType("datetime")
                   .IsRequired();

            builder.Property(e => e.Situation)
                   .HasColumnName("Situation")
                   .HasColumnType("Int")
                   .IsRequired();

            builder.HasOne(c => c.Supervisor);

        }
       
    }
}
