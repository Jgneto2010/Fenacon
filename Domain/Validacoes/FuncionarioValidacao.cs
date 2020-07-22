using Domain.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validacoes
{
    public class FuncionarioValidacao : AbstractValidator<Funcionario>
    {
        public FuncionarioValidacao()
        {
            RuleFor(c => c.Nome).NotEmpty().WithMessage("O nome não pode ser vazio")
                                .MaximumLength(250);

            RuleFor(c => c.Cpf).NotEmpty().WithMessage("O Cpf não pode ser vazio")
                                .MaximumLength(11).WithMessage("Cpf Incorreto")
                                 .MinimumLength(11).WithMessage("Cpf Incorreto");

            RuleFor(c => c.Endereco).NotEmpty().WithMessage("O Endereço não pode ser vazio")
                                .MaximumLength(214)
                                 .MinimumLength(10).WithMessage("Formato Endereço incorreto");

        }
    }
}
