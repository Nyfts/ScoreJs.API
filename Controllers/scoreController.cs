using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JsRank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class scoreController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            // var values = await _context.Values.ToListAsync();

            var values = "{\"score\":[{\"nome\":\"Luan\",\"score\":100},{\"nome\":\"Tura\",\"score\":50}]}";

            return Ok(values);
        }
    }
}