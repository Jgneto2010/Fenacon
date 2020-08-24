using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


        private readonly IFuncionarios _funcRepository;

        public FuncionarioController(IFuncionarios funcRepository)
        {
            
            _funcRepository = funcRepository;
        }

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
                FeriasVencida = addFuncionario.FeriasVencida,
                Situacao = addFuncionario.Situacao,
                IdSupervisor = addFuncionario.IdSupervisor,
                
            };
            
            funcionario.FeriasVencida = funcionario.ValidarFerias(funcionario.DataAdmissao);
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
            var listaFuncionarios = repositorio.GetAllFunc().ToList();

            if (listaFuncionarios == null)
                return default;

            var quantidade = listaFuncionarios.Count();

            var novaLista = listaFuncionarios.Select(x => new FuncionarioListaModel
            {
                Nome = x.Nome,
                Cargo = Enum.Parse(typeof(Cargo), x.Cargo.ToString()).ToString(),
                Cpf = x.Cpf,
                Endereco = x.Endereco,
                Situacao =  Enum.Parse(typeof(Situacao), x.Situacao.ToString()).ToString(),
                FeriasVencidas = x.FeriasVencida,
                Supervisor = new SupervisorListaModel
                {
                    Nome = x.Supervisor.Nome
                }
            });

            return Ok(new
            {
                quantidasde = quantidade,
                lista = novaLista
            });
        }



        [HttpGet]
        [Route("listaFuncionarioEmFerias")]
        public async Task<IActionResult> GetFuncionariosEmFerias([FromServices] IFuncionarios repositorio)
        {
            var listaFuncionarios = repositorio.GetAllFerias().ToList();

            if (listaFuncionarios == null)
                return default;

            var quantidade = listaFuncionarios.Count();

            var novaLista = listaFuncionarios.Select(x => new FuncionarioListaModel
            {
                Nome = x.Nome,
                Cargo = Enum.Parse(typeof(Cargo), x.Cargo.ToString()).ToString(),
                Cpf = x.Cpf,
                Endereco = x.Endereco,
                Situacao = Enum.Parse(typeof(Situacao), x.Situacao.ToString()).ToString(),
                FeriasVencidas = x.FeriasVencida,
                Supervisor = new SupervisorListaModel
                {
                    Nome = x.Supervisor.Nome
                }
            });

            return Ok(new
            {
                quantidasde = quantidade,
                lista = novaLista
            });
        }


        [HttpGet]
        [Route("FuncionarioId")]
        public async Task<IActionResult> GetFuncionarioPorId(Guid id)
        {
            var funcionario = _funcRepository.GetById(id);

            if (funcionario == null)
                return default;

            return Ok(new
            {
                lista = funcionario
            });
        }

    }
}
