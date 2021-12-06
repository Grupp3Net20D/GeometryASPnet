using GeometriTDD.Geometry;
using Microsoft.AspNetCore.Mvc;

namespace GeometryGrupp3.Controllers
{
    public class SquareController : Controller
    {
        public IActionResult Index(Square square)
        {
            var area = square.GetArea();
            var perimeter = square.GetPerimeter();
            ViewData["area"] = area;
            ViewData["perimeter"] = perimeter;
            return View();
        }
    }
}
