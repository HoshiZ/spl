using Microsoft.EntityFrameworkCore;

namespace SPL.Models.Database
{
    public class Box
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastModificationTime { get; set; }
        public string? BoxId { get; set; }
        public string? IsDeleted { get; set; }
        public string? StationCodeNow { get; set; }
        public string? WharfNow { get; set; }
        public string? ConveyerLineNow { get; set; }
        public string? NowInConveyerLineBlockList { get; set; }
        public int? InBlockIdNow { get; set; }
        public string? ProductType { get; set; }
        public string? LineCode { get; set; }
        public string? BoxState { get; set; }
        public string? BoxType { get; set; }
        public string? MaterialState { get; set; }
        public string? CellLevel { get; set; }
        public string? Technology { get; set; }

        public IEnumerable<Box> GetSeed()
        {
            var seedList = new List<Box>();
            for (int i = 10; i < 100; i++)
            {
                var lineCode = i % 2 == 0 ? "L05" : "L06";
                var seed = new Box { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, BoxId = $"JNF1F021{i}-113", IsDeleted = "False", StationCodeNow = "OP1", ProductType = "C13FLLA", LineCode = lineCode, BoxState = "Have", BoxType = "Sorting" };
                seedList.Add(seed);
            }
            return seedList;
        }
    }
}
