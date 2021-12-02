using GeometriTDD.Geometry;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometryGrupp3.Controllers
{
    public class RombController : Controller
    {
        public IActionResult Index(Romb romb)
        {
            var perimeter = romb.GetPerimeter();
            var area = romb.GetArea();
            ViewData["perimeter"] = perimeter;
            ViewData["area"] = area;
            return View();
        }
    }
}
