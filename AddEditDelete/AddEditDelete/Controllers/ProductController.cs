using AddEditDelete.Models;
using Microsoft.AspNetCore.Mvc;
using MyNetCoreMVC.Models;
using System.Linq;
using AddEditDelete.Models;

namespace APP.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context;
        }
        public IActionResult Update(Product product)
        {
            var existProduct = _context.Products.Find(product.id);
            if(existProduct == null)
            {
                return NotFound();
            }
            existProduct.name = product.name;
            existProduct.price = product.price;
            _context.Products.Update(existProduct);
            _context.SaveChanges();
            TempData["Message"] = "Update Success";
            return Redirect("Create");

        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View(_context.Products.ToList());

        }

        [HttpPost]
        public IActionResult Save(Product pr)
        {
            _context.Products.Add(pr);
            _context.SaveChanges();
            return new RedirectResult("Create");
        }
        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            var exisProduct = _context.Products.Find(product.id);
            if (exisProduct == null)
            {
                return NotFound();
            }

            exisProduct.name = product.name;
            exisProduct.price = product.price;
            _context.Products.Update(exisProduct);
            _context.SaveChanges();

            return new RedirectResult("Create");
        }

        [HttpPost]
        public IActionResult Delete(int id, Product product)
        {
            var exisProduct = _context.Products.Find(product.id);
            if (exisProduct == null)
            {
                return NotFound();
            }
            _context.Products.Remove(exisProduct);
            _context.SaveChanges();

            return new RedirectResult("Create");
        }
        public IActionResult Delete(int ID)
        {
            return new JsonResult(new Product
            {
                id = ID
            });
        }
    }
}