﻿using Microsoft.AspNetCore.Mvc;
using MovieTickets.Data;
using MovieTickets.Data.Services;

namespace MovieTickets.Controllers
{
    public class ActorsController : Controller
    {

        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAll();
            return View(allActors);
        }

        //Get request
        public IActionResult Create()
        {
            return View();
        }
    }
}
