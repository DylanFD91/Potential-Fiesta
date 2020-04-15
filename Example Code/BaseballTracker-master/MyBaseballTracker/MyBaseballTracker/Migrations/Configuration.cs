namespace MyBaseballTracker.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyBaseballTracker.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyBaseballTracker.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Hitters.AddOrUpdate(
                new Models.Hitter { FirstName = "Ryan", LastName = "Braun", Position = "LF", Games = 30, AtBats = 102, Runs = 12, HomeRuns = 6, RunsBattedIn = 18, BattingAverage = .206 },
                new Models.Hitter { FirstName = "Christian", LastName = "Yelich", Position = "RF", Games = 29, AtBats = 102, Runs = 26, HomeRuns = 14, RunsBattedIn = 34, BattingAverage = .353 }
            );
        }
    }
}
