using Domain.Entidades;
using Domain.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuario
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<Usuario> DbSet;
        public UsuarioRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<Usuario>();
        }
       

        public bool ObterUsuarioPeloNome(string login, string password)
        {
            var test = DbSet.ToList();

            var rest = DbSet.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
            if (rest == null)
            {
                return false;
            }
            return true;
        }
    }
}
