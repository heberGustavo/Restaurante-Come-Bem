using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteComeBem.Controllers
{
    public class FluxoCaixaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
