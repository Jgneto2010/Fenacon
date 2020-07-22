using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entidades
{
    public class Funcionario : Entity
    {
        public Funcionario(){}
        public Funcionario(string nome, string cpf, string endereco, DateTime dataAdmissao)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            DataAdmissao = dataAdmissao;
            Id = Guid.NewGuid();
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime CargaHoraria { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Supervisor? Supervisor { get; set; }
        public Situacao Situacao { get; set; }

        public bool ValidaDiasTrabalhados(DateTime dataAdmissao)
        {
            var dateSolicitation = DateTime.Now;


            if (dataAdmissao.Month > 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
