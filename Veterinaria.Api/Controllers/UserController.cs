using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VeterinariaApi.Abstractions.IApplication;

namespace Veterinaria.Api.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserApplication _userApplication;

        public UserController(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }
        [HttpGet]
        [Route("List")]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var res = await _userApplication.GetAll();
                return Ok(res);
            }
            catch (Exception ex)
            {
            return BadRequest(ex.Message);
             }
        }
    }
}
