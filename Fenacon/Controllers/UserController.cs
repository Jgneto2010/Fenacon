using Domain.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fenacon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        //[HttpGet]
        //[Route("user[controller]")]
        //public IEnumerable<User> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        //[HttpPost]
        //[Route("user[controller]")]
        //public async Task<IActionResult> Post([FromBody] User user)
        //{
        //    var novo = new User();

        //    novo.Id = user.Id;
        //    novo.Name = user.Name;
        //    novo.Login = user.Login;
        //    novo.Password = user.Password;
        //    novo.ConfirmPassword = user.ConfirmPassword;

            
          

        //    await novo.(prod);
        //    await productRepository.SaveChanges();
        //    return Created($"api/product/{prod.Id}", new { prod.Price, prod.Name, prod.Id });
        //}
    }
}
