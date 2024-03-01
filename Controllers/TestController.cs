using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPL.Data;
using SPL.Models;

namespace SPL.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ServiceDBContext _context;
        
        public TestController(ServiceDBContext context)
        {
            _context = context;
        }

        [HttpGet("getBlockData")]
        public async Task<ActionResult<IEnumerable<Block>>> GetBlockData()
        {
            //var a = new Block();
            //return a.GetCorrectPosition();
            var block = await _context.Blocks.ToListAsync();
            return Block.GetCorrectPosition2(block);
        }
    }
}
