using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IFuncionarios : IRepositorio<Funcionario>
    {
        List<Funcionario> GetAllFunc();
    }
}
