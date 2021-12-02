namespace GeometryGrupp3.Controllers
{
    using GeometriTDD.Geometry;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CircleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Circle circle)
        {
            var inputRadius = circle.Radie;

            var area = circle.GetArea();
            var perimeter = circle.GetPerimeter();
            ViewData["area"] = area;
            ViewData["perimeter"] = perimeter;
            return View();
        }
    }
}
