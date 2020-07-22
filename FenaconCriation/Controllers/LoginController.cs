using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidades;
using Domain.Interfaces;
using Domain.Modelos;
using Infra.Repositorios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FenaconCriation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        [Route("loginUsuario")]
        public async Task<IActionResult> GetUsuarioById([FromServices] IUsuario repositorio, [FromQuery] LoginModel loginModel)
        {
            var result =  repositorio.ObterUsuarioPeloNome(loginModel.Login, loginModel.Senha);


            return Ok();
        }
    }
}
