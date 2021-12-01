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
        [HttpPost]
        public IActionResult Index(Triangle triangle)
        {
            var result = triangle.GetArea();
            ViewData["results"] = result;
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult SaveDetail(float side)
        {
            return View();
        }


    }
}
