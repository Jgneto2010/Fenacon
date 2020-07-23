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
    }
}
