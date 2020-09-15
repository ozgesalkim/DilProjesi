using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DilProjesi.BLL.Abstact;
using DilProjesi.BLL.Models.DilDto;
using DilProjesi.COMMON;
using DilProjesi.Web.Models;
using DilProjesi.Web.Models.Sozcuk;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace DilProjesi.Web.Controllers
{
    public class SozcukController : Controller
    {
        private readonly ISozcukService _sozcukService;
        private readonly IDilService _dilService;
        private readonly IProjeService _projeService;

        public SozcukController(ISozcukService sozcukService, IDilService dilService, IProjeService projeService)
        {
            _sozcukService = sozcukService;
            _dilService = dilService;
            _projeService = projeService;
        }

        public IActionResult Listele()
        {
            return View();
        }

        public IActionResult LoadTable(DataTableRequest request)
        {
            var response = _sozcukService.LoadTable(request);

            return Json(response);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            //ViewData["Diller"] = _dilService.GetAll();
            //TempData["Diller"] = _dilService.GetAll();
            //ViewBag.Diller = _dilService.GetAll();

            ViewBag.Projeler = _projeService.GetAll().Select(proje => 
            new SelectListItem 
            {
                Text = proje.Ad,
                Value = proje.Id.ToString()
            });

            var vModel = new SozcukEkleViewModel()
            {
                Diller = _dilService.GetAll().Select(proje =>
                new CheckBoxDilDto
                {
                    Ad = proje.Ad,
                    Id = proje.Id,
                    SeciliMi = false
                }).ToList()
            };

            return View(vModel);
        }

        [HttpPost]
        public IActionResult EklePost(SozcukEkleViewModel viewModel)
        {
            var sonuc = _sozcukService.Add(viewModel.Sozcuk);
            if (sonuc)
            {
                return RedirectToAction(nameof(Listele));
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            var sonuc = _sozcukService.GetByIdForUpdate(id);
            var viewModel = new SozcukGuncelleViewModel()
            {
                Sozcuk = sonuc,
                Diller = _dilService.GetAll().Select(proje =>
                new CheckBoxDilDto
                {
                    Ad = proje.Ad,
                    Id = proje.Id,
                    SeciliMi = false
                }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult GuncellePost(SozcukGuncelleViewModel viewModel)
        {
            var sonuc = _sozcukService.Update(viewModel.Sozcuk);
            if (sonuc)
            {
                return RedirectToAction(nameof(Listele));
            }

            return View(viewModel);
        }
    }
}

