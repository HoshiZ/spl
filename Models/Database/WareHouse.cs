namespace SPL.Models.Database
{
    public class WareHouse
    {
        public Guid Id { get; set; }
        public DateTime? CreationTime { get; set; }
        public string? WarehouseId { get; set; }
        public string? WarehouseName { get; set; }

        public IEnumerable<WareHouse> GetSeed()
        {
            var seedList = new List<WareHouse>();

            seedList.Add(new WareHouse { Id = Guid.NewGuid(), CreationTime = DateTime.Now, WarehouseId = "L05_GWJR", WarehouseName = "5线高温浸润" });
            seedList.Add(new WareHouse { Id = Guid.NewGuid(), CreationTime = DateTime.Now, WarehouseId = "L06_GWJR", WarehouseName = "5线高温浸润" });

            seedList.Add(new WareHouse { Id = Guid.NewGuid(), CreationTime = DateTime.Now, WarehouseId = "L05_ZFDCF", WarehouseName = "5线自放电存放1" });
            seedList.Add(new WareHouse { Id = Guid.NewGuid(), CreationTime = DateTime.Now, WarehouseId = "L06_ZFDCF", WarehouseName = "6线自放电存放1" });

            seedList.Add(new WareHouse { Id = Guid.NewGuid(), CreationTime = DateTime.Now, WarehouseId = "L05-06_CPK", WarehouseName = "5-6线成品库" });

            return seedList;
        }
    }
}
