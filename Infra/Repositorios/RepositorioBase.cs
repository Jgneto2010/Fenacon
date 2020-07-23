using Domain.Entidades;
using Domain.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
