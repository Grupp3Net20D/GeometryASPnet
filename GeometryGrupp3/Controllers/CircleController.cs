namespace GeometryGrupp3.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CircleController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public float GetPerimeter(float radius)//måste tänka om med hur vi kommer åt properties 
        {
            GeometriTDD.Geometry.Circle circle = new();

            var perimeter= circle.GetPerimeter();
            return perimeter;         
        }
    }
}
