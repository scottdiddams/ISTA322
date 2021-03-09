using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }
        public ViewResult Index()
        {
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            decimal priceFilterTotal = productArray
                .Filter(p => (p?.Price ?? 0) >= 20)     //lambda expression "=>" read as "goes to"
                .TotalPrices();
            decimal nameFilterTotal = productArray
                .Filter(p => p?.Name?[0] == 'S')        //lambda expression
                .TotalPrices();

            return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}" });
        }


        /*
            decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
            decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();
            return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}" });
        }
        */
    }
}


/*
namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ShoppingCart cart
                = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M}
            };
            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.TotalPrices();

            return View("Index", new string[] {
                $"Cart Total: {cartTotal:C2}",
                $"Array Total: {arrayTotal:C2}" });

            /*
            List<string> results = new List<string>();  //List<type parameter> name = constructor
            foreach (Product p in Product.GetProducts())
            {
                /*
                string name = p?.Name;          //null conditional Operator - property "Name" can be null
                decimal? price = p?.Price;      //If Name or Price is null - returns a blank
                string relatedName = p?.Related?.Name;  //Chaining: p is the object with two properties Related & Name
                */

/*       //use null coalescing operator to replace all null values:
   string name = p?.Name ?? "<No Name>";
   decimal? price = p?.Price ?? 0.00M;
   string category = p?.Category ?? "<General>";
   string relatedName = p?.Related?.Name ?? "<None>";
   results.Add(string.Format($"Category: {category}, Name: {name}, Price: {price}, Related: {relatedName}"));
}
*/

/*
Dictionary<string, Product> products = new Dictionary<string, Product> //constructs a dictionary called products
{
    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
};
return View("Index", products.Keys);    //Keys: a property of the dictionary [strings]
//return View(results);
*/
/*
}
}
}
*/
/*using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()   //Action method
        {
            return View(new string[] { "C#", "Language", "Features" });
        }
    }
}
*/