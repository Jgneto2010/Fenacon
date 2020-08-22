using Microsoft.AspNetCore.Mvc;
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
           
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime CargaHoraria { get; set; }
        public DateTime DataAdmissao { get; set; }
        public bool FeriasVencida { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        public Guid IdSupervisor { get; set; }
        public Situacao Situacao { get; set; }

        
        
        
        public bool ValidarFerias(DateTime dataAdmissao)
        {
            var dataAtual = DateTime.Now.Subtract(dataAdmissao);

            if (dataAtual.Days > 547)
            {
                return true;
            }

            return false;

        }
    }
}
