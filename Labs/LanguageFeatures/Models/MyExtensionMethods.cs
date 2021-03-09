using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Product> Filter(
                this IEnumerable<Product> productEnum,
                Func<Product, bool> selector)   //method named selector - input Product, output bool
        {
            foreach (Product prod in productEnum)
            {
                if (selector(prod))
                {
                    yield return prod;
                }
            }
        }



        /*
        public static IEnumerable<Product> FilterByPrice(
                this IEnumerable<Product> productEnum, decimal minimumPrice)
        {
            foreach (Product prod in productEnum)
            {
                if ((prod?.Price ?? 0) >= minimumPrice)
                {
                    yield return prod;
                }
            }
        }
        //Lambda expression
        public static IEnumerable<Product> FilterByName(
                this IEnumerable<Product> productEnum, char firstLetter)
        {
            foreach (Product prod in productEnum)
            {
                if (prod?.Name?[0] == firstLetter)
                {
                    yield return prod;
                }
            }
        }
        */
    }
}




/*
namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
    }
}
*/








/*
namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods  //Extension methods have to be defined in a public static class
    {
        public static decimal TotalPrices(this ShoppingCart cartParam)  //this ShoppingCart means this method extends ShoppingCart
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
    }
}
*/