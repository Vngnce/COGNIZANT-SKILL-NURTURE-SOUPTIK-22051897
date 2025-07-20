using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet("secret")]
        [Authorize]
        public IActionResult GetSecretData()
        {
            return Ok(new { Data = "This is protected data, only visible with valid JWT!" });
        }
    }
}
