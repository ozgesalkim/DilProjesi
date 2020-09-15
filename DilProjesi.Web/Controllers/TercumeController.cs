using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DilProjesi.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DilProjesi.Web.Controllers
{
    public class TercumeController : Controller
    {
        private readonly ILogger<TercumeController> _logger;

        public TercumeController(ILogger<TercumeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

