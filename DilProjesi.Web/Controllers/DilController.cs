using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DilProjesi.BLL.Abstact;
using DilProjesi.Web.Models;
using DilProjesi.Web.Models.Dil;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DilProjesi.Web.Controllers
{
    public class DilController : Controller
    {
        private readonly IDilService _dilService;

        public DilController(IDilService dilService)
        {
            _dilService = dilService;
        }

        [HttpGet]
        public IActionResult Listele()
        {
            var models = _dilService.GetAll();
            var viewModel = new DilListeleViewModel()
            {
                Diller = models
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EklePost(DilEkleViewModel viewModel)
        {
            var sonuc = _dilService.Add(viewModel.Dil);
            if (sonuc)
            {
                return RedirectToAction(nameof(Listele));
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            var sonuc = _dilService.GetByIdForUpdate(id);
            var viewModel = new DilGuncelleViewModel()
            {
                Dil = sonuc
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult GuncellePost(DilGuncelleViewModel viewModel)
        {
            var sonuc = _dilService.Update(viewModel.Dil);
            if (sonuc)
            {
                return RedirectToAction(nameof(Listele));
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Sil(int id)
        {
            var sonuc = _dilService.GetById(id);
            var viewModel = new DilSilViewModel()
            {
                Dil = sonuc
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SilPost(DilGuncelleViewModel viewModel)
        {
            var sonuc = _dilService.Delete(viewModel.Dil.Id);
            if (sonuc)
            {
                return RedirectToAction(nameof(Listele));
            }

            return View(viewModel);
        }
    }
}

