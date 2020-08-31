using Domain.Entidades;
using Domain.Interfaces;
using Domain.Modelos;
using Domain.Validacoes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            if (addUsuario.Password != addUsuario.ConfirmPassword)
            {
                return NotFound();
            }
            
            var usuario = new Usuario
            {
                Name = addUsuario.Name,
                Login = addUsuario.Login,
                Password = addUsuario.Password,
                ConfirmPassword = addUsuario.ConfirmPassword

            };

            var validacao = new UsuarioValidacao().Validate(usuario);
            usuario.Encrypt();

            if (validacao.IsValid)
            {
                repositorio.Add(usuario);
                repositorio.SaveChanges();
                return Ok(usuario);
            }

            return Ok(validacao.Errors);

           
        }
       
        [HttpGet]
        [Route("listaUsuario")]
        public async Task<IActionResult> GetUsuarioLista([FromServices] IUsuario repositorio)
        {
            var listaUsuario = repositorio.GetAll().ToList();
            var quantidade = listaUsuario.Count();

            var novaLista = listaUsuario.Select(x => new UsuarioListaModel
            {
                Name = x.Name
            });

            return Ok(new
            {
                quantidasde = quantidade,
                lista = novaLista
            });
        }

        [HttpDelete]
        [Route("ExcluirUsuario")]
        public async Task<IActionResult> ExcluirUsuario([FromServices] IUsuario repository, Guid id)
        {
            repository.Remove(id);
            repository.SaveChanges();
            return Ok();
        }

    }

   
}
