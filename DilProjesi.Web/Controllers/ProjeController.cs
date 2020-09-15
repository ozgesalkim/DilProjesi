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
        private readonly IProjeService _projeService;

        public ProjeController(IProjeService projeService)
        {
            _projeService = projeService;
        }

        [HttpGet]
        public IActionResult Listele()
        {
            var models = _projeService.GetAll();
            var viewModel = new ProjeListeleViewModel()
            {
                Projeler = models
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EklePost(ProjeEkleViewModel viewModel)
        {
            var sonuc =_projeService.Add(viewModel.Proje);
            if (sonuc)
            {
                return RedirectToAction(nameof(Listele));
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            var sonuc = _projeService.GetByIdForUpdate(id);
            var viewModel = new ProjeGuncelleViewModel()
            {
                Proje = sonuc
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult GuncellePost(ProjeGuncelleViewModel viewModel)
        {
            var sonuc = _projeService.Update(viewModel.Proje);
            if (sonuc)
            {
                return RedirectToAction(nameof(Listele));
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Sil(int id)
        {
            var sonuc = _projeService.GetById(id);
            var viewModel = new ProjeSilViewModel()
            {
                Proje = sonuc
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SilPost(ProjeGuncelleViewModel viewModel)
        {
            var sonuc = _projeService.Delete(viewModel.Proje.Id);
            if (sonuc)
            {
                return RedirectToAction(nameof(Listele));
            }

            return View(viewModel);
        }
    }
}