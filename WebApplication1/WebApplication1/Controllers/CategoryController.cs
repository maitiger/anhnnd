using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        public readonly MyDBContext _context;
        public CategoryController(MyDBContext context)
        {
            _context = context;

        }
        public IActionResult Detail(long Id)
        {
            var category = _context.Categories
                .Include(c => c.ListProduct)
                .SingleOrDefault(c => c.id == Id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
    }
   
}
