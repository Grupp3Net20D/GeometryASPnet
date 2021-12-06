using GeometriTDD.Geometry;
using Microsoft.AspNetCore.Mvc;

namespace GeometryGrupp3.Controllers
{
    public class PentagonController : Controller
    {
        public IActionResult Index(Pentagon pentagon)
        {
            var perimeter = pentagon.GetPerimeter();
            var area = pentagon.GetArea();
            ViewData["perimeter"] = perimeter;
            ViewData["area"] = area;
            return View();
        }
    }
}