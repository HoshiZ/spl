namespace SPL.Models.Database
{
    public class TaskInfo
    {
        public Guid Id { get; set; }
        public DateTime? CreationTime { get; set; }
        public string? TaskId { get; set; }
        public string? BoxId { get; set; }
        public string? TaskType { get; set; }
        public string? Position { get; set; }
        public string? State { get; set; }
        public string? Remark { get; set; }
    }
}
