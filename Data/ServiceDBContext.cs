using Microsoft.EntityFrameworkCore;
using SPL.Models;
using SPL.Models.Database;

namespace SPL.Data
{
    public class ServiceDBContext : DbContext
    {
        public DbSet<Box> Boxes { get; set; }
        public DbSet<BoxDetails> BoxDetails { get; set; }
        public DbSet<ConveyerLine> ConveyerLines { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<InShelves> InShelves { get; set; }
        //public DbSet<LineCache> LineCache { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<OutShelves> OutShelves { get; set; }
        public DbSet<StrategyFlow> StrategyFlows { get; set; }
        public DbSet<TaskInfo> TaskInfo { get; set; }
        public DbSet<WareHouse> WareHouse { get; set; }
        public DbSet<Wharf> Wharves { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Station> Stations { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var connectionString = "Server=127.0.0.1;Database=wa_ceshi1;User Id=root;Password=1707;Charset=utf8mb4;";
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var box = new Box();
            var boxDetail = new BoxDetails();
            var conveyerLine = new ConveyerLine();
            var device = new Device();
            var inshelves = new InShelves();
            var locations = new Locations();
            var outshelves = new OutShelves();
            var strategyFlow = new StrategyFlow();
            var taskInfo = new TaskInfo();
            var warehouse = new WareHouse();
            var wharf = new Wharf();
            var block = new Block();
            var station = new Station();

            modelBuilder.Entity<Box>().HasData(box.GetSeed());
            modelBuilder.Entity<ConveyerLine>().HasData(conveyerLine.GetSeed());
            modelBuilder.Entity<Device>().HasData(device.GetSeed());
            modelBuilder.Entity<Locations>().HasData(locations.GetSeed());
            modelBuilder.Entity<StrategyFlow>().HasData(strategyFlow.GetSeed());
            modelBuilder.Entity<WareHouse>().HasData(warehouse.GetSeed());
            modelBuilder.Entity<Wharf>().HasData(wharf.GetSeed());
            modelBuilder.Entity<Block>().HasData(block.GetSeedBlockMap());

            modelBuilder.Entity<Station>().HasData(station.GetSeed());

        }
    }
}
