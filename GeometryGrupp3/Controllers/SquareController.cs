using GeometriTDD.Geometry;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometryGrupp3.Controllers
{
    public class SquareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Square square)
        {
            var inputRadius = square.Side;

            var area = square.GetArea();
            var perimeter = square.GetPerimeter();
            ViewData["area"] = area;
            ViewData["perimeter"] = perimeter;
            return View();
        }

    }
}
