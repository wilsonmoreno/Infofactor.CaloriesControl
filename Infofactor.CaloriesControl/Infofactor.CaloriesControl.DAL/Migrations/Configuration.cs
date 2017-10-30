namespace Infofactor.CaloriesControl.DAL.Migrations
{
    using Infofactor.CaloriesControl.DAL.Model;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Infofactor.CaloriesControl.DAL.ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Infofactor.CaloriesControl.DAL.ModelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var foods = new List<FoodItem>
            {
                new FoodItem { CaloriesPerPortion = 70, Name = "All-Bran Cereal" },
                new FoodItem { CaloriesPerPortion = 2240, Name = "Apple Pie" },
                new FoodItem { CaloriesPerPortion = 105, Name = "Bananas" },
                new FoodItem { CaloriesPerPortion = 10, Name = "Barbecue Sauce" },
                new FoodItem { CaloriesPerPortion = 95, Name = "Beer, Light" },
                new FoodItem { CaloriesPerPortion = 150, Name = "Beer, Regular" },
                new FoodItem { CaloriesPerPortion = 75, Name = "Blackberries" },
                new FoodItem { CaloriesPerPortion = 100, Name = "Blue Cheese" },
                new FoodItem { CaloriesPerPortion = 40, Name = "Broccoli" },
                new FoodItem { CaloriesPerPortion = 2465, Name = "Cherry Pie" },
                new FoodItem { CaloriesPerPortion = 110, Name = "Corn Flakes, Kellogg's" },
                new FoodItem { CaloriesPerPortion = 100, Name = "French Bread" },
                new FoodItem { CaloriesPerPortion = 245, Name = "Hamburger, Regular" },
                new FoodItem { CaloriesPerPortion = 90, Name = "Marshmallows" },
                new FoodItem { CaloriesPerPortion = 1910, Name = "Olive Oil" },
                new FoodItem { CaloriesPerPortion = 105, Name = "Potato Chips" },
                new FoodItem { CaloriesPerPortion = 670, Name = "Rice White" }
             };

            foods.ForEach(f => context.FoodItem.AddOrUpdate(item => item.Name, f));
            context.SaveChanges();

            /// Adding Roles
            var roles = new List<Role>
            {
                new Role{ Name = "Client"},
                new Role{ Name = "Manager" }
            };

            roles.ForEach(r => context.Roles.AddOrUpdate(item => item.Name, r));
            context.SaveChanges();

            // Adding Clients and Manager
            var users = new List<User>
            {
                new User{ Name = "Wilson Moreno", UserName = "wilsonmoreno@info-factor.com", RoleId = 1},
                new User{ Name = "Jerónimo Castro", UserName = "jeronimo@info-factor.com", RoleId = 1},
                new User{ Name = "Manager", UserName = "admin@info-factor.com", RoleId = 1},
            };

            users.ForEach(u => context.Users.AddOrUpdate(item => item.UserName, u));
            context.SaveChanges();
        }
    }
}
