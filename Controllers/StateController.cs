using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        [HttpGet]
        public string Get([FromServices]IConfiguration configuration) => System.IO.File.ReadAllText(configuration["STATE_STORAGE_PATH"] + "/state.txt");

        [HttpPost]
        public void Post([FromServices]IConfiguration configuration, [FromBody]string newState) => System.IO.File.WriteAllText(configuration["STATE_STORAGE_PATH"] + "/state.txt", newState);
    }
}
