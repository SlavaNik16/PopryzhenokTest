
using System.Data.Entity;


namespace PopryzhenokTest.DB
{

    public class ApplicationContextDB : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContextDB() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("TUsers");
            modelBuilder.Entity<User>().HasKey(x => x.Id);
        }

    }			

}
