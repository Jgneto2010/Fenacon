using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepositorio<T>
         where T : Entity
    {
        void Add(T obj);
        int SaveChanges();
        List<T> GetAll();
        List<T> GetAllFunc();

    }
   
}
