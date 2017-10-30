namespace Infofactor.CaloriesControl.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CaloriesLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        MealId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        NoPortion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FoodItem", t => t.MealId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.MealId);
            
            CreateTable(
                "dbo.FoodItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500, unicode: false),
                        CaloriesPerPortion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500, unicode: false),
                        UserName = c.String(nullable: false, maxLength: 200, unicode: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserName, unique: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CaloriesLog", "UserId", "dbo.User");
            DropForeignKey("dbo.User", "RoleId", "dbo.Role");
            DropForeignKey("dbo.CaloriesLog", "MealId", "dbo.FoodItem");
            DropIndex("dbo.User", new[] { "RoleId" });
            DropIndex("dbo.User", new[] { "UserName" });
            DropIndex("dbo.CaloriesLog", new[] { "MealId" });
            DropIndex("dbo.CaloriesLog", new[] { "UserId" });
            DropTable("dbo.Role");
            DropTable("dbo.User");
            DropTable("dbo.FoodItem");
            DropTable("dbo.CaloriesLog");
        }
    }
}
