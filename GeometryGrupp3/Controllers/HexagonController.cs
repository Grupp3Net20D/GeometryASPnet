using GeometriTDD.Geometry;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometryGrupp3.Controllers
{
    public class HexagonController : Controller
    {
        public IActionResult Index(Hexagon hexagon)
        {
           var area = hexagon.GetArea();
           var perimeter = hexagon.GetPerimeter();
            ViewData["perimeter"] = perimeter;
            ViewData["area"] = area;
            
            return View("Index");
        }
    }
}
