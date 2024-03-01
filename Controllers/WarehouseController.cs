using Microsoft.AspNetCore.Mvc;
using SPL.Models.Database;

namespace SPL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehouseController
    {
        [HttpGet("getWarehouseDetail")]
        public IEnumerable<WareHouse> GetWarehouseDetail()
        {
            WareHouse wareHouse = new WareHouse();
            return wareHouse.GetSeed();
        }
    }
}
