using DirectoryStructure.Data;
using DirectoryStructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.IO;

namespace DirectoryStructure.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(DataContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Dir directory = new Dir();
            directory.DirName0 = _context.Directory.First(t => t.DirId == "0").DirName;
            directory.DirName1 = _context.Directory.First(t => t.DirId == "1").DirName;
            directory.DirName2 = _context.Directory.First(t => t.DirId == "2").DirName;
            directory.DirName3 = _context.Directory.First(t => t.DirId == "3").DirName;
            return View(directory);
        }

        public IActionResult Resources()
        {
            Dir directory = new Dir();
            directory.DirName0 = _context.Directory.First(t => t.DirId == "1").DirName;
            directory.DirName1 = _context.Directory.First(t => t.DirId == "4").DirName;
            directory.DirName2 = _context.Directory.First(t => t.DirId == "5").DirName;
            return View(directory);
        }

        public IActionResult Graphic_Products()
        {
            Dir directory = new Dir();
            directory.DirName0 = _context.Directory.First(t => t.DirId == "3").DirName;
            directory.DirName1 = _context.Directory.First(t => t.DirId == "6").DirName;
            directory.DirName2 = _context.Directory.First(t => t.DirId == "7").DirName;
            return View(directory);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}