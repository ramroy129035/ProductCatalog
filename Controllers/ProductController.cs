using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Description = "High performance laptop for students",
                Price = 55000,
                Category = "Electronics",
                Quantity = 10,
                ImageUrl = "/images/laptop.jpg"
            },

            new Product
            {
                Id = 2,
                Name = "Smartphone",
                Description = "Latest smartphone with advanced features",
                Price = 25000,
                Category = "Electronics",
                Quantity = 15,
                ImageUrl = "/images/smartphone.jpg"
            
            },

            new Product
            {
                Id = 3,
                Name = "Headphone",
                Description = "Wireless headphone with clear sound",
                Price = 2500,
                Category = "Accessories",
                Quantity = 20,
                ImageUrl = "/images/headphones.jpg"
            },
            new Product
            {
                Id = 4,
                Name = "Watch",
                Description = "Smart watch with fitness tracking",
                Price = 1500,
                Category = "Accessories",
                Quantity = 25,
                ImageUrl = "/images/Watch.jpg"
            },
            new Product
            {
                Id = 5,
                Name = "Refrigerator",
                Description = "Large capacity refrigerator with energy efficiency",
                Price = 45000,
                Category = "Appliances",
                Quantity = 5,
                ImageUrl = "/images/refrigerator.jpg"
            }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
