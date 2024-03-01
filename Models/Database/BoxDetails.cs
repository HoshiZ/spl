namespace SPL.Models.Database
{
    public class BoxDetails
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string? BoxId { get; set; }
        public string? Barcode { get; set; }
        public string? BoxIndex { get; set; }
        public string? State { get; set; }

        public IEnumerable<BoxDetails> GetSeed()
        {
            return Enumerable.Empty<BoxDetails>();
        }
    }
}
