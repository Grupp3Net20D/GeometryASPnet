using GeometriTDD.Geometry;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometryGrupp3.Controllers
{
    public class TriangleController : Controller
    {
        public IActionResult Index(Triangle triangle)
        {
            var area = triangle.GetArea();
            var perimeter = triangle.GetPerimeter();
            ViewData["area"] = area;        
            ViewData["perimeter"] = perimeter;
            return View();
        }
    }
}
