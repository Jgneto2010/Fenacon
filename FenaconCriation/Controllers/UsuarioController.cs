using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidades;
using Domain.Interfaces;
using Domain.Modelos;
using Domain.Validacoes;
using Infra.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FenaconCriation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrarUsuario")]
        public IActionResult CadastrarUsuario([FromServices] IUsuario repositorio, [FromBody] UsuarioModel addUsuario)
        {
            var usuario = new Usuario
            {
                Name = addUsuario.Name,
                Login = addUsuario.Login,
                Password = addUsuario.Password,
                ConfirmPassword = addUsuario.ConfirmPassword

            };

            var validacao = new UsuarioValidacao().Validate(usuario);

            if (validacao.IsValid)
            {
                repositorio.Add(usuario);
                repositorio.SaveChanges();
                return Ok(usuario);
            }

            return Ok(validacao.Errors);

           
        }
       
    }
}
