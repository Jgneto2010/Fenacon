using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entidades
{
    public class Supervisor : Entity
    {
        public Supervisor(){}
        public string Nome { get; set; }
        public IEnumerable<Funcionario> Funcionarios { get; set; }
    }
}
