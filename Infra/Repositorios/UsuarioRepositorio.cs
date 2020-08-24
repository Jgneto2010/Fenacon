using Domain.Entidades;
using Domain.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            var senha = EncryptRest(password);
            var rest = DbSet.Where(x => x.Login == login && x.Password == senha).FirstOrDefault();
            

            if (rest != null)
            {
                return true;
            }
            
            return false;
        }

        public string EncryptRest(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            password = strBuilder.ToString();

            return password;
        }
    }
}
