using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidades;
using Domain.Interfaces;
using Domain.Modelos;
using Domain.Validacoes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FenaconCriation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrarUsuario")]
        public IActionResult CadastrarFuncionario([FromServices] IFuncionarios repositorio, [FromBody] FuncionarioModel addFuncionario)
        {


            var funcionario = new Funcionario
            {
                Nome = addFuncionario.Nome,
                Cpf = addFuncionario.Cpf,
                Endereco = addFuncionario.Endereco,
                Cargo = addFuncionario.Cargo,
                CargaHoraria = addFuncionario.CargaHoraria,
                DataAdmissao = addFuncionario.DataAdmissao,
                Supervisor = addFuncionario.Supervisor,
                Situacao = addFuncionario.Situacao
                
            };

            var validacao = new FuncionarioValidacao().Validate(funcionario);
           

            if (validacao.IsValid)
            {
                repositorio.Add(funcionario);
                repositorio.SaveChanges();
                return Ok(funcionario);
            }

            return Ok(validacao.Errors);


        }
       
    }
}
