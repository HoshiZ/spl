namespace SPL.Models.Database
{
    public class InShelves
    {
        public Guid Id { get; set; }
        public DateTime? CreationTime { get; set; }
        public string? InShelvesId { get; set; }
        public string? WarehouseId { get; set; }
        public string? LocationId { get; set; }
        public string? BoxId { get; set; }
        public string? BoxState { get; set; }
        public string? Barcodes { get; set; }
        public string? Position { get; set; }
        public string? TaskId { get; set; }

        // 这个不用种子数据
    }
}
