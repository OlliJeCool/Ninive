using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ninive.Models;
using Ninive.Services;

namespace Ninive.Controllers
{
    [ApiController]
    [Route("api")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("user/auth")]
        public IActionResult Authenticate([FromBody] AuthVm model)
        {
            var user = _authService.Authenticate(model);
            if(user is null)
            {
                return BadRequest("Invalid login!");
            }
            else { return Ok(user); }
        }
    }
}
