using ExternalModels.Library;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FluentValication.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(Developer developer)
        {
            return Ok();
        }

    }
}
