using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appventas.Models;

namespace appventas.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
         public IActionResult Create( contacto objContacto)
        {
            objContacto.Status ="Registrado" ;
            ViewData["Message"] = "el contacto ya esta " + objContacto.Status;
            return View("Index");
        }
}
}
