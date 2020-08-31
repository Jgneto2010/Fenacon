using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidades;
using Domain.Interfaces;
using Domain.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FenaconCriation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupervisorController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrarFuncionario")]
        public IActionResult CadastrarFuncionario([FromServices] ISupervisor repositorio, [FromBody] SupervisorModel addsupervisor)
        {

            var supervisor = new Supervisor
            {
               Nome = addsupervisor.Nome

            };

            repositorio.Add(supervisor);
            repositorio.SaveChanges();
            return Ok(supervisor);

        }

        [HttpGet]
        [Route("listaSupervisores")]
        public async Task<IActionResult> GetSupervisorLista([FromServices] ISupervisor repositorio)
        {
            var listaSupervisor = repositorio.GetAll().ToList();

            var quantidade = listaSupervisor.Count();

            var novaLista = listaSupervisor.Select(x => new SupervisorListaModel
            {
                Nome = x.Nome,
               
            });

            return Ok(new
            {
                quantidasde = quantidade,
                lista = novaLista
            });
        }

        [HttpDelete]
        [Route("ExcluirSupervisor")]
        public async Task<IActionResult> ExcluirSupervisor([FromServices] ISupervisor repository, Guid id)
        {
            repository.Remove(id);
            repository.SaveChanges();
            return Ok();
        }
    }
}
