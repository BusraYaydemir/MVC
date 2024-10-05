using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Entities.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContext _context;
        public ProductController(RepositoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Index1()
        {   
            /*
            !1- veriyi tek tek elle vermek
            return new List<Product>() {
                new Product() {
                    ProductId = 1, ProductName = "Laptop", Price = 17_000
                }
            };
            */

            /*
            !2- Veriyi veri tabanından almak
            var context = new RepositoryContext(
                new DbContextOptionsBuilder<RepositoryContext>().UseSqlite("Data Source = C:\\Users\\Zeno\\Documents\\Github\\MVC\\ProductDb.db").Options
            );
            return context.Products;
            */

            //!3- contexti ctor ile alma
            return _context.Products;
        }

        public IActionResult Index()
        {
            var model = _context.Products.ToList();
            return View(model);
        }

        public IActionResult Get(int id)
        {
            Product product = _context.Products.First(p => p.ProductId.Equals(id));
            return View(product);
        }
    }
}