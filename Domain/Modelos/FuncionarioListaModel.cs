using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Modelos
{
    public class FuncionarioListaModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public String Cargo { get; set; }
        public Supervisor? Supervisor { get; set; }
        public string Situacao { get; set; }
    }
}
