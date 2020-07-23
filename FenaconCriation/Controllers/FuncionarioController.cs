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
        [Route("cadastrarFuncionario")]
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

        [HttpGet]
        [Route("listaFuncionario")]
        public async Task<IActionResult> GetFuncionarioLista([FromServices] IFuncionarios repositorio)
        {
            var listaUsuario = repositorio.GetAllFunc().ToList();

            var quantidade = listaUsuario.Count();

            var novaLista = listaUsuario.Select(x => new FuncionarioListaModel
            {
                Nome = x.Nome,
                Cargo = Enum.Parse(typeof(Cargo), x.Cargo.ToString()).ToString(),
                Cpf = x.Cpf,
                Endereco = x.Endereco,
                Situacao =  Enum.Parse(typeof(Situacao), x.Situacao.ToString()).ToString(),
                Supervisor = x.Supervisor,
            });

            return Ok(new
            {
                quantidasde = quantidade,
                lista = novaLista
            });
        }

    }
}
