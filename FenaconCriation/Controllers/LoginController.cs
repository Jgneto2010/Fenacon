using Domain.Interfaces;
using Domain.Modelos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FenaconCriation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("loginUsuario")]
        public async Task<IActionResult> GetUsuarioById([FromServices] IUsuario repositorio, [FromBody] LoginModel loginModel)
        {
            var result =  repositorio.ObterUsuarioPeloNome(loginModel.Login, loginModel.Senha);

            if (result == true)
            {
                return Ok("Usuario Logado com Sucesso");
            }

            return NotFound("Senha ou Login Incorreto");
        }
    }
}
