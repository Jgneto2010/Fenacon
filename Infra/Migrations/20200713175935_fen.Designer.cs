﻿// <auto-generated />
using System;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200713175935_fen")]
    partial class fen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entidades.Funcionario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CargaHoraria")
                        .HasColumnName("workload")
                        .HasColumnType("datetime");

                    b.Property<int>("Cargo")
                        .HasColumnName("Office")
                        .HasColumnType("Int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnName("Cpf")
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnName("AdmissionDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Name_User")
                        .HasColumnType("varchar(40)");

                    b.Property<int>("Situacao")
                        .HasColumnName("Situation")
                        .HasColumnType("Int");

                    b.Property<Guid?>("SupervisorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SupervisorId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Domain.Entidades.Gerente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Gerentes");
                });

            modelBuilder.Entity("Domain.Entidades.Supervisor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Supervisor");
                });

            modelBuilder.Entity("Domain.Entidades.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_User")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnName("ConfirmPassword")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnName("Login")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name_User")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Password")
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Entidades.Funcionario", b =>
                {
                    b.HasOne("Domain.Entidades.Supervisor", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorId");
                });
#pragma warning restore 612, 618
        }
    }
}
