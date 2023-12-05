using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestJwtApi.Models;
using TestJwtApi.Services;

namespace TestJwtApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Register")]
        public async Task < IActionResult > RegisterAsync(RegisterModel model)
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);
        
            var result = await _authService.RegisterAsync(model);

            if (!result.IsAutenticated)
                return BadRequest(result.Message);

            return Ok (result);
            
        }

        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync (TokenRequestModel model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.GetTokenAsync(model);

            if(!result.IsAutenticated)
                  return BadRequest(result.Message);

            return Ok (result);
        }

        [HttpPost("AddRole")]
        public async Task<IActionResult> AddRoleAsync(AddRoleModel model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.AddRoleAsync(model);

            if(! string.IsNullOrEmpty(result))
                return BadRequest(result);

            return Ok(model);
        }


    }
}
