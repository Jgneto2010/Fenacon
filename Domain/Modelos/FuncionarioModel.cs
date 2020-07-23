using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Modelos
{
    public class FuncionarioModel
    {

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime CargaHoraria { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Supervisor? Supervisor { get; set; }
        public Situacao Situacao { get; set; }
    }
}
