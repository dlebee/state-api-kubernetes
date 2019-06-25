using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebugController : ControllerBase
    {
        [HttpGet]
        public string Get([FromServices]IConfiguration configuration) => configuration["STATE_STORAGE_PATH"];
    }
}
