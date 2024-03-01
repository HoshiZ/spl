namespace SPL.Models.Database
{
    public class Locations
    {
        public Guid Id { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public string? IsDeleted { get; set; }
        public string? WarehouseId { get; set; }
        public string? LocationId { get; set; }
        public string? BoxId { get; set; }
        public int? Alley { get; set; }
        public int? Row { get; set; }
        public int? Col { get; set; }
        public string? State { get; set; }
        public string? UseSign { get; set; }
        public string? InstockTime { get; set; }
        public string? AllowOutDateTime { get; set; }
        public string? OverTimeForOut { get; set; }
        public string? ArtRemark { get; set; }

        public IEnumerable<Locations> GetSeed()
        {
            var seedList = new List<Locations>();

            for (int i = 1; i <=2 ; i++)
            {
                for (int j = 1; j <= 50; j++)
                {
                    for (int k = 1; k <= 10; k++)
                    {
                        seedList.Add(new Locations { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, IsDeleted = "0", WarehouseId = "L05_GWJR", LocationId = $"{i}-{j}-{k}", Alley = i, Row = j, Col = k, State = "Empty", UseSign = "Enable" });
                    }
                }
            }

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 50; j++)
                {
                    for (int k = 1; k <= 10; k++)
                    {
                        seedList.Add(new Locations { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, IsDeleted = "0", WarehouseId = "L06_GWJR", LocationId = $"{i}-{j}-{k}", Alley = i, Row = j, Col = k, State = "Empty", UseSign = "Enable" });
                    }
                }
            }

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 50; j++)
                {
                    for (int k = 1; k <= 10; k++)
                    {
                        seedList.Add(new Locations { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, IsDeleted = "0", WarehouseId = "L05_ZFDCF1", LocationId = $"{i}-{j}-{k}", Alley = i, Row = j, Col = k, State = "Empty", UseSign = "Enable" });
                    }
                }
            }

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 50; j++)
                {
                    for (int k = 1; k <= 10; k++)
                    {
                        seedList.Add(new Locations { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, IsDeleted = "0", WarehouseId = "L06_ZFDCF1", LocationId = $"{i}-{j}-{k}", Alley = i, Row = j, Col = k, State = "Empty", UseSign = "Enable" });
                    }
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 50; j++)
                {
                    for (int k = 1; k <= 10; k++)
                    {
                        seedList.Add(new Locations { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, IsDeleted = "0", WarehouseId = "L05-06_CPK", LocationId = $"{i}-{j}-{k}", Alley = i, Row = j, Col = k, State = "Empty", UseSign = "Enable" });
                    }
                }
            }

            return seedList;
        }
    }
}
