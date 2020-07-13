using Domain.Interfaces;
using Domain.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.IUser
{
    public interface IEmployee : IRepository<Employee>
    {
    }
}
