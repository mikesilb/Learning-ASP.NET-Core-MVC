using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //public async Task<ViewResult> Index()
        //{
        //    long? length = await MyAsyncMethods.GetPageLength();
        //    return View(new string[] { $"Length: {length}" });
        //}

        public ViewResult Index()
        {
            var products = new[] {
            new { Name = "Kayak", Price = 275M},
            new { Name =  "Lifejacket", Price = 48.95M},
            new { Name = "Soccer Ball", Price = 19.50M},
            new { Name = "Corner flag", Price = 34.95M}
            };
            //return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
            return View(products.Select(p => $"{nameof(p.Name)} {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }


            //return View(products.Select(p => p.GetType().Name));



        //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));

            
        //public ViewResult Index()
        //{
            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };



            //Product[] productArray = {
            //    new Product { Name = "Kayak", Price = 275M},
            //    new Product { Name = "Lifejacket", Price = 48.95M},
            //    new Product { Name = "Soccer ball", Price = 19.50M},
            //    new Product { Name = "Corner flag", Price = 34.95M}
            //};

            //Func<Product, bool> nameFilter = delegate (Product prod)
            //{
            //return prod?.Name?[0] == 'S';
            //};

            //decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 35).TotalPrices();
            //decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0]== 'S').TotalPrices();

            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();
            //decimal filteredArrayPriceTotal = productArray.FilterByPrice(35).TotalPrices();
            //decimal filteredArrayNameTotal = productArray.FilterByName('S').TotalPrices(); 

            //return View("Index", new string[] {$"Cart Total: {cartTotal}, Filtered Array by Price Total: {filteredArrayPriceTotal}, Array Total: {arrayTotal}, Filtered Array by Name Total: {filteredArrayNameTotal}, Price Total Lambda: {priceFilterTotal}, Name Total Lambda: {nameFilterTotal}"});





            //return View(Product.GetProducts().Select(p => p?.Name));
        
         //}


    }
}
