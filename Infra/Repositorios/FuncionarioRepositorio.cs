using Domain.Entidades;
using Domain.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorios
{
    public class FuncionarioRepositorio : RepositorioBase<Funcionario>, IFuncionarios
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<Funcionario> DbSet;
        public FuncionarioRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<Funcionario>();
        }
    }
}
