using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using producto.Models;

namespace producto.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
       public IActionResult MetodoVenta(Producto objProducto){
           double resultado = 0.0;
           String  message ="";
           String message2 ="";
           resultado = objProducto.Precio * objProducto.Cantidad * 1.18;
           message2= "el producto elegido es \n" + objProducto.Nombre;
           message = "el precio del producto es \n" + resultado;
           
       ViewData["Messages"] = message2 + "\n";
      ViewData["Message"] = message;
      return View("index");
      
       }

    }
}
