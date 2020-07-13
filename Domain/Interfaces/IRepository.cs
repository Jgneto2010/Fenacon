using Domain.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IRepository<T>
      where T : Entity
    {
        void Add(T obj);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        void UpDate(T obj);
        void Remove(Guid id);
        int SaveChanges();
    }
}
