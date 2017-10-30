using Infofactor.CaloriesControl.DAL.Model;
using System.Data.Entity;

namespace Infofactor.CaloriesControl.DAL
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=InfoFactorCalDBConnectionString")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModelContext, Migrations.Configuration>("InfoFactorCalDBConnectionString"));
            Database.SetInitializer(new ModelDBInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<CaloriesLog> CaloriesLog { get; set; }
        public DbSet<FoodItem> FoodItem { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
