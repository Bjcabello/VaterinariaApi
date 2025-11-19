using System;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VeterinariaApi.Abstractions.IApplication;
using VeterinariaApi.DTOs.Auth;

namespace Veterinaria.Api.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserApplication _userApplication;

        public AuthController(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginRequestDto request)
        {
            try
            {
                var res = await _userApplication.Login(request);
                return Ok(res);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
