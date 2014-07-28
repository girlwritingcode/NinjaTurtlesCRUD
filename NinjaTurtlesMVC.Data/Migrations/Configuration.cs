namespace NinjaTurtlesMVC.Data.Migrations
{
    using NinjaTurtlesMVC.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NinjaTurtlesMVC.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NinjaTurtlesMVC.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Turtles.AddOrUpdate(t => t.Name,
                new Turtle("Leonardo", "blue", "Katana and shoto (swords), grappling hook, smoke bombs, ninja glider", "strong leader", "BIO", "bio_leonardo_2.gif", "leonardo.png"),
                new Turtle("Raphael", "red", "Sai; Grappling Hook; Smoke Bombs; Ninja Glider", "aggressive", "BIO", "bio_raphael_2.gif", "raphael.png")
                );
        }
    }
}
