using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUsuario : IRepositorio<Usuario>
    {
        bool ObterUsuarioPeloNome(string nome, string login);
    }
}
