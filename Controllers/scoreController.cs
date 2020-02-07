using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScoreJs.API.Data;

namespace ScoreJs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class scoreController : ControllerBase
    {
        private readonly DataContext _context;
        public scoreController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> getValues()
        {
            var Values = await _context.score.ToListAsync();
            return Ok(Values);
        }

        [HttpPost]
        public void Put([FromBody] string value)
        {
        }
    }
}