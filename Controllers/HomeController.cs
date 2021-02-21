using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Models;
using Shop.Data;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }
        private readonly ShopContext _context;
        public HomeController(ShopContext context)
        {
            _context = context;
        }
        public List<ProductView> DanhSachSanPham(string id = "")
        {
            if(id == "")
                return new List<ProductView>(0);
            var listProducts = _context.Products.Where(m => m.IdType == id).ToList();
            if(listProducts == null)
                return new List<ProductView>(0);
            return listProducts;
        }
        public IActionResult Index()
        {
            var listProducts = _context.Products.Where(m => m.IdType == "1").ToList();
            return View(listProducts);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
