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
      
        public FuncionarioRepositorio(Contexto contexto) : base(contexto)
        {
            
        }

        public List<Funcionario> GetAllFunc()
        {
            return DbSet
                .Include(x => x.Supervisor)
                .OrderBy(x => x.DataAdmissao)
                .ToList();
        }

        public List<Funcionario> GetAllFerias()
        {
            return DbSet
                 .Include(x => x.Supervisor)
                 .OrderBy(x => x.DataAdmissao).Where(x => x.FeriasVencida == true)
                 .ToList();
        }

    }
}
