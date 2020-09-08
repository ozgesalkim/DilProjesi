using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DilProjesi.BLL.Abstact;
using DilProjesi.Web.Models;
using DilProjesi.Web.Models.Proje;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DilProjesi.Web.Controllers
{
    public class ProjeController : Controller
    {
        private readonly ILogger<ProjeController> _logger;

        public ProjeController(ILogger<ProjeController> logger)
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
    }
}