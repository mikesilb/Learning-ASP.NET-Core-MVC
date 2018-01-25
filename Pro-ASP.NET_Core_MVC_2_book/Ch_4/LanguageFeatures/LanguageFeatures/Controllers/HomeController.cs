using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                string category = p?.Category ?? "<None>";
                bool? instock = p?.InStock ?? false;

                results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}, Category: {3}, InStock: {4}", name, price, relatedName, category, instock));
            }

            return View(results);
        }
    }
}
