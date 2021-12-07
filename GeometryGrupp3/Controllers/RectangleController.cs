namespace GeometryGrupp3.Controllers
{
    using GeometriTDD.Geometry;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class RectangleController : Controller
    {
        public IActionResult Index(Rectangle rectangle)
        {
            var area = rectangle.GetArea();
            var perimeter = rectangle.GetPerimeter();
            ViewData["area"] = area;
            ViewData["perimeter"] = perimeter;
            return View();
        }
    }
}
