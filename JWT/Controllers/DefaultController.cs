using JWT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult Login()
        {
            return Created("", new BuildToken().CreateToken());
        }

        [Authorize]
        [HttpGet("CustomerList")]
        public IActionResult CustomerList()
        {
            return Ok("Müşteri Listesi Sayfasına Hoşgeldiniz");

        }
    }
}
