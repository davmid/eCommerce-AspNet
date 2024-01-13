﻿using Microsoft.AspNetCore.Mvc;
using shop_view.data.services;
using shop_view.Models;

namespace ProjektASPNET.Controllers
{
    public class ManufacturersController : Controller
    {
        private readonly IManufacturerService _service;

        public ManufacturersController(IManufacturerService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var manufaturer = await _service.GetByIdAsync(id);
            return View(manufaturer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(manufacturer);
                return RedirectToAction(nameof(Index));
            }
            return View(manufacturer);
        }
    }
}