using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using repasodb.Data;
using repasodb.Models;

namespace repasodb.Controllers
{
    [Route("contacto")]
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context;

        public ContactoController(ILogger<ContactoController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Ruta explícita para Index
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }

        // Método POST para Enviar
        [HttpPost("enviar")]
        public IActionResult Enviar(Contacto objcontacto)
        {
            _logger.LogDebug("Ingreso a Enviar Mensaje");
            _context.Add(objcontacto);
            _context.SaveChanges();

            ViewData["Message"] = "Se registró el contacto";
            return View("Index");
        }

        // Ruta explícita para Error
        [HttpGet("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
