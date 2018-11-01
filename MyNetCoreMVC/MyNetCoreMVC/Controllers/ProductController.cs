using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyNetCoreMVC.Models;


namespace MyNetCoreMVC.Controllers
{
    public class ProductController : Controller

    {
        private readonly Product _context;

        public ProductController(Product context)
        {
            _context = context;
        }
        public IActionResult GetList()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewData["Name"] = "Đây là trường Name";
            ViewData["Price"] = "Đây là trường Price";
            return View();
        }
        public IActionResult Update()
        {
            return View();

        }
        public IActionResult Delete(int id)
        {
            return new JsonResult(new Product
            {
                Id = id
            });
        }
    }
}

