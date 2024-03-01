namespace SPL.Models.Database
{
    public class StrategyFlow
    {
        public Guid Id { get; set; }
        public DateTime? CreationTime { get; set; }
        public string? CreatorId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public string? LastModifierId { get; set; }
        public string? IsDeleted { get; set; }
        public string? DeleterId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string? FlowId { get; set; }
        public string? FlowName { get; set; }
        public string? StrategyValue { get; set; }
        public string? StrategyId { get; set; }

        
        public IEnumerable<StrategyFlow> GetSeed()
        {
            var seedList = new List<StrategyFlow>();


            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "YCZY_STATION_TIME", FlowName = "一次注液机执行时间", StrategyValue = "20", StrategyId = "" });
            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "YC_STATION_TIME", FlowName = "预充机执行时间", StrategyValue = "20", StrategyId = "" });
            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "GWJR_WAREHOUSE_TIME", FlowName = "高温浸润仓库存储时间", StrategyValue = "3600", StrategyId = "" });
            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "CD_STATION_TIME", FlowName = "充电机执行时间", StrategyValue = "20", StrategyId = "" });
            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "GWLH_STATION_TIME", FlowName = "高温老化机执行时间", StrategyValue = "20", StrategyId = "" });
            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "JW_STATION_TIME", FlowName = "降温机执行时间", StrategyValue = "20", StrategyId = "" });
            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "ZFDCF1_WAREHOUSE_TIME", FlowName = "自放电存放1仓库存储时间", StrategyValue = "20", StrategyId = "" });
            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "OCV1_STATION_TIME", FlowName = "OCV1机执行时间", StrategyValue = "20", StrategyId = "" });
            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "CPK_WAREHOUSE_TIME", FlowName = "成品库仓库存储时间", StrategyValue = "3600", StrategyId = "" });
            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "STACKER_TIME", FlowName = "堆垛机执行时间", StrategyValue = "20", StrategyId = "" });

            seedList.Add(new StrategyFlow { Id = Guid.NewGuid(), CreationTime = DateTime.Now, CreatorId = "Admin", LastModificationTime = DateTime.Now, LastModifierId = "Admin", IsDeleted = "0", FlowId = "BLOCK_MOVE_TIME", FlowName = "单个线体的移动时间", StrategyValue = "2", StrategyId = "" });

            
            return seedList;
        }
    }
}
