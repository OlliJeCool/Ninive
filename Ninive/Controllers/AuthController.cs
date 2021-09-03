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
        private readonly IUserService _userService;
        public AuthController(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
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

        [HttpPost("user/newPass")]
        public IActionResult ChangePassword([FromBody] AuthVm model, ChangePasswordVm newPin)
        {
            var user = _userService.ChangePassword(model, newPin);
            if(user is null) { return BadRequest("Error!"); }
            else { return Ok(user); }
        }
    }
}
