using Domain.Entidades;
using Domain.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositorios
{
    public class SupervisorRepositorio : RepositorioBase<Supervisor>, ISupervisor
    {
        public SupervisorRepositorio(Contexto contexto) : base(contexto){}
        public List<Supervisor> GetAllFunc()
        {
            return DbSet.Include(x => x.Funcionarios).ToList();
        }
    }
}
