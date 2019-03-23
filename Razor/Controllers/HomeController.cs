using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;
namespace Razor.Controllers
{
    public class HomeController:Controller
    {
        //public ViewResult Index()
        //{
        //    Product myProduct = new Product
        //    {
        //        ProductId = 1,
        //        Name = "Kyaka",
        //        Price = 275m,
        //        Description = "a boat for one person",
        //        Category = "Water Sport",
        //    };
        //    ViewBag.StockLevel1=2;
        //    return View(myProduct);
        //}
        public IActionResult Index()
        {
            Product[] array =
           {
            new Product {Name="Kayka",Price=245m },
            new Product {Name="Lifejacket",Price=45m },
            new Product {Name="Soccer ball",Price=43m },
            new Product {Name="Cornerflag",Price=42m }
            };
            return View(array);
        }
    }
}
