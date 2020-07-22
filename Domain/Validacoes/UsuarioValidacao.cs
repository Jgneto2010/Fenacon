using Domain.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validacoes
{
    public class UsuarioValidacao : AbstractValidator<Usuario>
    {
        public UsuarioValidacao()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("O nome não pode ser vazio")
                                .MaximumLength(250);

            RuleFor(c => c.Login).NotEmpty().WithMessage("O Login não pode ser vazio")
                                .MaximumLength(11).WithMessage("Login Incorreto")
                                 .MinimumLength(2).WithMessage("Login Incorreto");

            RuleFor(c => c.Password).NotEmpty().WithMessage("O Password deve ser preenchido não pode ser vazio")
                                .MaximumLength(214)
                                 .MinimumLength(2).WithMessage("Formato Password incorreto");
            
            RuleFor(c => c.ConfirmPassword).Equal(c => c.Password).WithMessage("As senhas não conferem")
                                .MaximumLength(214)
                                 .MinimumLength(2).WithMessage("Formato Password incorreto");

        }
    }
}
