namespace GuitarSOA.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GuitarSOA.GuitarDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GuitarSOA.GuitarDbContext context)
        {
            context.Guitars.AddOrUpdate(
                new Guitar { ID = 1, Make = "Fender", Model = "Telecaster", Year = 2008, Price = 340.00, Stock = 3 },
                new Guitar { ID = 2, Make = "Fender", Model = "Strat", Year = 2015, Price = 450.00, Stock = 2 },
                new Guitar { ID = 3, Make = "Martin", Model = "OO Maple", Year = 2001, Price = 900.00, Stock = 5 },
                new Guitar { ID = 4, Make = "Gibson", Model = "Les Paul", Year = 2016, Price = 900.00, Stock = 1 },
                new Guitar { ID = 5, Make = "Epiphone", Model = "12 String", Year = 2015, Price = 250.00, Stock = 4 },
                new Guitar { ID = 6, Make = "Gibson", Model = "Hummingbird", Year = 2012, Price = 780.00, Stock = 2 }
                );
        }
    }
}
