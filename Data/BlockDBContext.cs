//using Microsoft.EntityFrameworkCore;
//using SPL.Models;
//using SPL.Models.Database;

//namespace SPL.Data
//{
//    public class BlockDBContext : DbContext
//    {
//        public DbSet<Block> blocks { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            var seedData = new Block();
//            modelBuilder.Entity<ConveyerLine>().HasData(seedData.GetSeedBlockMap());
//        }
//    }
//}
