using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DatabaseModel;
using DatabaseModel.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyDystopianUniverse.Models;

namespace MyDystopianUniverse.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult CarregarPosts(int UltimoPostId = 0)
        {
            var post = new PostCore().RetornarPorId(1);
            var json = Json(post);
            return Json(json);
        }
    }
}
