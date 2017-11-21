namespace BabyStore.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    internal sealed class Configuration : DbMigrationsConfiguration<BabyStore.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(BabyStore.DAL.StoreContext context)
        {
            var categories = new List<Category>{
                new Category { CategoryName = "Clothes" },
                new Category { CategoryName = "Play and Toys" },
                new Category { CategoryName = "Feeding" },
                new Category { CategoryName = "Medicine" },
                new Category { CategoryName= "Travel" },
                new Category { CategoryName= "Sleeping" }
            };

            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.CategoryName, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product
                {
                    ProductName = "Sleep Suit",
                    Description ="For sleeping or general wear",
                    Price =4.99M,
                    CategoryID =categories.Single( c => c.CategoryName == "Clothes").ID
                },
                new Product
                {
                    ProductName = "Vest",
                    Description ="For sleeping or general wear",
                    Price =2.99M,
                    CategoryID =categories.Single( c => c.CategoryName == "Clothes").ID
                },
                new Product
                {
                    ProductName = "Orange and Yellow Lion",
                    Description ="Makes a squeaking noise",
                    Price =1.99M,
                    CategoryID =categories.Single( c => c.CategoryName == "Play and Toys").ID
                },
                new Product
                {
                    ProductName = "3 Pack of Bottles",
                    Description ="For a leak free drink everytime",
                    Price =24.99M,
                    CategoryID =categories.Single( c => c.CategoryName == "Feeding").ID
                },
                new Product
                {
                    ProductName = "Blue Rabbit",
                    Description ="Baby comforter",
                    Price =2.99M,
                    CategoryID =categories.Single(c => c.CategoryName == "Play and Toys").ID
                },
                new Product
                {
                    ProductName = "3 Pack of Bibs",
                    Description ="Keep your baby dry when feeding",
                    Price =8.99M,
                    CategoryID =categories.Single( c => c.CategoryName == "Feeding").ID
                },
                new Product
                {
                    ProductName = "Powdered Baby Milk",
                    Description ="Nutritional and Tasty",
                    Price =9.99M,
                    CategoryID =categories.Single( c => c.CategoryName =="Feeding").ID
                },
                new Product
                {
                    ProductName = "Pack of 70 Disposable Nappies",
                    Description ="Dry and secure nappies with snug fit",
                    Price =19.99M,
                    CategoryID =categories.Single(c => c.CategoryName == "Feeding").ID
                },
                new Product
                {
                    ProductName = "Colic Medicine",
                    Description ="For helping with baby colic pains",
                    Price =4.99M,
                    CategoryID =categories.Single( c => c.CategoryName== "Medicine").ID
                },
                new Product
                {
                    ProductName = "Reflux Medicine",
                    Description ="Helps to prevent milk regurgitation and sickness",
                    Price =4.99M,
                    CategoryID =categories.Single(c => c.CategoryName == "Medicine").ID},
                new Product
                {
                    ProductName = "Black Pram and Pushchair System",
                    Description ="Convert from pram to pushchair, with raincover",
                    Price =299.99M,
                    CategoryID =categories.Single(c => c.CategoryName == "Travel").ID
                },
                new Product
                {
                    ProductName = "Car Seat",
                    Description ="For safe car travel",
                    Price =49.99M,
                    CategoryID = categories.Single(c => c.CategoryName =="Travel").ID
                },
                new Product
                {
                    ProductName = "Moses Basket",
                    Description ="Plastic moses basket",
                    Price =75.99M,
                    CategoryID =categories.Single(c => c.CategoryName =="Sleeping").ID
                },
                new Product
                {
                    ProductName = "Crib",
                    Description ="Wooden crib",
                    Price =35.99M,
                    CategoryID = categories.Single(c => c.CategoryName == "Sleeping").ID
                },
                new Product
                {
                    ProductName = "Cot Bed",
                    Description ="Converts from cot into bed for older children",
                    Price =149.99M,
                    CategoryID =categories.Single( c =>c.CategoryName == "Sleeping").ID
                },
                new Product
                {
                    ProductName = "Circus Crib Bale",
                    Description ="Contains sheet, duvet and bumper",
                    Price =29.99M,
                    CategoryID =categories.Single( c => c.CategoryName =="Sleeping").ID
                },
                new Product
                {
                    ProductName = "Loved Crib Bale",
                    Description ="Contains sheet, duvet and bumper",
                    Price =35.99M,
                    CategoryID =categories.Single( c =>c.CategoryName == "Sleeping").ID
                }
            };

            products.ForEach(c => context.Products.AddOrUpdate(p => p.ProductName, c));
            context.SaveChanges();
        }
    }
}