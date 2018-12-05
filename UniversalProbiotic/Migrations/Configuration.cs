namespace UniversalProbiotic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UniversalProbiotic.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UniversalProbiotic.Models.ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(UniversalProbiotic.Models.ModelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //context.Products.AddOrUpdate(
            //    new Product
            //    {
            //        Name = "Canine Supplement",
            //        Price = 26.95M,
            //        Species = "Canine",
            //        PictureType = null,
            //        PictureData = null
            //    },
            //    new Product
            //    {
            //        Name = "Cat Pre and Probiotic Supplement",
            //        Price = 26.95M,
            //        Species = "Feline",
            //        PictureType = null,
            //        PictureData = null
            //    },
            //    new Product
            //    {
            //        Name = "Goat Pre and Probiotic Supplement",
            //        Price = 41.00M,
            //        Species = "Doe",
            //        PictureType = null,
            //        PictureData = null
            //    },
            //    new Product
            //    {
            //        Name = "Horse Pre and Probiotic Supplement",
            //        Price = 32.00M,
            //        Species = "Equine",
            //        PictureType = null,
            //        PictureData = null
            //    },
            //    new Product
            //    {
            //        Name = "Chicken and Turkey Pre and Probiotic Supplement",
            //        Price = 39.00M,
            //        Species = "Poultry",
            //        PictureType = null,
            //        PictureData = null
            //    },
            //    new Product
            //    {
            //        Name = "Pig Pre and Probiotic Supplement",
            //        Price = 39.00M,
            //        Species = "Swine",
            //        PictureType = null,
            //        PictureData = null
            //    },
            //    new Product
            //    {
            //        Name = "Cow Pre and Probiotic Supplement",
            //        Price = 39.00M,
            //        Species = "Bovine",
            //        PictureType = null,
            //        PictureData = null
            //    });
                
        }
    }
}
