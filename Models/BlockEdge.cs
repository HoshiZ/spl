namespace SPL.Models
{
    public class BlockEdge
    {
        public Guid Id { get; set; }
        public int StartBlock { get; set; }
        public int EndBlock { get; set; }

        
        public IEnumerable<BlockEdge> GetSeed()
        {
            var seedList = new List<BlockEdge>();


            return Enumerable.Empty<BlockEdge>();
        }
    }
}
