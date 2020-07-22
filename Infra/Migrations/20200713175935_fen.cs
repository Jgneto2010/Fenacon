﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class fen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gerentes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supervisor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_User = table.Column<string>(type: "varchar(40)", nullable: false),
                    Name_User = table.Column<string>(type: "varchar(40)", nullable: false),
                    Login = table.Column<string>(type: "varchar(40)", nullable: false),
                    Password = table.Column<string>(type: "varchar(40)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_User);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name_User = table.Column<string>(type: "varchar(40)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    Address = table.Column<string>(type: "varchar(80)", nullable: false),
                    Office = table.Column<int>(type: "Int", nullable: false),
                    workload = table.Column<DateTime>(type: "datetime", nullable: false),
                    AdmissionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SupervisorId = table.Column<Guid>(nullable: true),
                    Situation = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Supervisor_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_SupervisorId",
                table: "Funcionarios",
                column: "SupervisorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Gerentes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Supervisor");
        }
    }
}
