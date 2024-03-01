using Microsoft.AspNetCore.Mvc;
using SPL.Models;
using SPL.Services.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SPL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CeshiController : ControllerBase
    {
        private readonly IGraphService _graphService;

        public CeshiController(IGraphService graphService)
        {
            _graphService = graphService;
        }

        [HttpGet("getLine")]
        public IEnumerable<string> GetLine()
        {
            var a = _graphService.GetPath("1", "2");
            return a;
        }

        [HttpGet("base")]
        public IEnumerable<Line> GetBase()
        {
            var baseData = new Line().GetSeedData();
            return baseData;
        }

        // GET: api/<CeshiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CeshiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CeshiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CeshiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CeshiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
