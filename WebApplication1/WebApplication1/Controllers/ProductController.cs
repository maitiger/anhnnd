using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using static WebApplication1.Models.MyDBContext;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public readonly MyDBContext _context;
        public  ProductController(MyDBContext context)
        {
            _context = context;
            context.Database.EnsureCreated();
        }

        public IActionResult Index()
        {
            var listProduct = _context.Products.Include(c => c.Category).ToList();
            return View();

        }
        public IActionResult Create()
        {
            return View(_context.Products.ToList());

        }
        public IActionResult Update(Product product)
        {
            var existProduct = _context.Products.Find(product.Id);
            if (existProduct == null)
            {
                return NotFound();
            }
            existProduct.Name = product.Name;
            existProduct.Price = product.Price;
            _context.Products.Update(existProduct);
            _context.SaveChanges();
            TempData["Message"] = "Update Success";
            return Redirect("Create");

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
            var exisProduct = _context.Products.Find(product.Id);
            if (exisProduct == null)
            {
                return NotFound();
            }

            exisProduct.Name = product.Name;
            exisProduct.Price = product.Price;
            _context.Products.Update(exisProduct);
            _context.SaveChanges();

            return new RedirectResult("Create");
        }

        [HttpPost]
        public IActionResult Delete(int id, Product product)
        {
            var exisProduct = _context.Products.Find(product.Id);
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
                Id = ID
            });
        }
    }
}