﻿using LanchesCM.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LanchesCM.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminGraficoController : Controller
    {
        private readonly GraficosVendasService _graficoVendas;

        public AdminGraficoController(GraficosVendasService graficoVendas)
        {
            _graficoVendas = graficoVendas ?? throw
                new ArgumentNullException(nameof(graficoVendas));
        }

        public JsonResult VendasLanches(int dias)
        {
            var lanchesVendasTotais = _graficoVendas.GetVendasLanches(dias);
            return Json(lanchesVendasTotais);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasMensal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasSemanal()
        {
            return View();
        }
    }
}
