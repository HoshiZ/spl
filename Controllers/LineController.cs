//using Microsoft.AspNetCore.Mvc;
//using SPL.Data;
//using SPL.Models;
//using SPL.Models.Database;

//namespace SPL.Controllers
//{
//    [ApiController]
//    [Route("/api/[controller]")]
//    public class LineController
//    {
//        private readonly ServiceDBContext _context;

//        public LineController(ServiceDBContext context)
//        {
//            _context = context;
//        }

//        [HttpGet("getNextLineByWharfId")]
//        public IEnumerable<Block> getNextLineByWharfId(string nowWharf, string nextWharf)
//        {
//            var nowWharfInfo = _context.Wharves.Where(x => x.WharfId == nowWharf).ToList().FirstOrDefault();
//            var nextWharfInfo = _context.Wharves.Where(x => x.WharfId == nextWharf).ToList().FirstOrDefault();

//            var nowWharfId = _context.Blocks
//        }
//    }
//}