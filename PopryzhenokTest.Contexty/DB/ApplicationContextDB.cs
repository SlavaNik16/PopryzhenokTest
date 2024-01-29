
using PopryzhenokTest.Contexty.Models;
using System.Data.Entity;


namespace PopryzhenokTest.DB
{

    public class ApplicationContextDB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Sale> Sales { get; set; }


        public ApplicationContextDB() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("TUsers");
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().ToTable("TProducts");
            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<Agent>().ToTable("TAgents");
            modelBuilder.Entity<Agent>().HasKey(x => x.Id);
            modelBuilder.Entity<Sale>().ToTable("TSales");
            modelBuilder.Entity<Sale>().HasKey(x => x.Id);

        }

    }			

}
