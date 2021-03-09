using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)       //stock is an optional parameter
        {
            InStock = stock;
        }
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }     //decimal? is a nullable value type
        public Product Related { get; set; }    //reference type Product, Property called related
        public bool? InStock { get; } 
        public static Product[] GetProducts()   //method that returns an array - static class method - called using the class name ie Products.GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };
            Product lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            Product paddle = new Product
            {
                Name = "Paddle",
                Price = 50.00M
            };
            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, paddle, null };
        }
    }
}


