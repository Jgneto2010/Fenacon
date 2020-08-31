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
    public class RepositorioBase<T> : IRepositorio<T>
        where T : Entity
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<T> DbSet;
        public RepositorioBase(Contexto contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<T>();
        }

        public void Add(T obj)
        {
             _contexto.Add(obj);
        }

        public int SaveChanges()
        {
            return _contexto.SaveChanges();
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public List<T> GetAllFunc()
        {
            return DbSet.ToList();
        }


        public T GetById(Guid id)
        {
            return DbSet.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<T> GetAllFerias()
        {
            return DbSet.ToList();
        }

        public void Remove(Guid id)
        {
            var test = GetById(id);
            DbSet.Remove(test);
            
        }
    }
}
