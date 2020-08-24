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
    public class FuncionarioRepositorio : RepositorioBase<Funcionario>, IFuncionarios
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<Funcionario> DbSet;
        public FuncionarioRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<Funcionario>();
        }

        public List<Funcionario> GetAllFunc()
        {
            return DbSet.AsNoTracking()
                .Include(x => x.Supervisor)
                .OrderBy(x => x.DataAdmissao)
                .ToList();
        }

        public List<Funcionario> GetAllFerias()
        {
            return DbSet.AsNoTracking()
                 .Include(x => x.Supervisor)
                 .OrderBy(x => x.DataAdmissao).Where(x => x.FeriasVencida == true)
                 .ToList();
        }


        public Funcionario GetById(Guid id)
        {
            var trt = _contexto.Funcionarios.Where(c => c.Id == id).First();

            return trt;

        }


    }
}
