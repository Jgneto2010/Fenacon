using Domain.Entidades;
using Domain.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorios
{
    public class SupervisorRepositorio : RepositorioBase<Supervisor>, ISupervisor
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<Supervisor> DbSet;
        public SupervisorRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<Supervisor>();
        }
        //public List<Funcionario> GetAllFunc()
        //{
        //    //return DbSet.AsNoTracking().Include(x => x.Supervisor).ToList();
        //}
    }
}
