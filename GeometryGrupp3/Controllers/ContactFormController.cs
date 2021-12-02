using GeometryGrupp3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GeometryGrupp3.Controllers
{
    public class ContactFormController : Controller
    {
        private readonly ILogger<ContactFormController> _logger;

        public ContactFormController(ILogger<ContactFormController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(ContactForm model)
        {
            string input = $"Följande person har skrivit till dig via kontaktformuläret:\n\nNamn:{ model.Fname} { model.Lname}\nEmail: { model.Email}\nMeddelande: { model.Msg}";
            if (model.HasSubscribedToNewsLetter)
            {
                input += "\nLägg till personen som prenumerant av nyhetsbrevet.";
            }

            //ViewData["input"] = input;

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var messageLog = Path.Combine(desktop, "Message.log");
            System.IO.File.AppendAllText(messageLog, "\n\n" + DateTime.Now + ":\n" + input);

            if (model.Fname == null || model.Lname == null || model.Email == null)
            {

                return View();
            }
            else
            {
               return View("../Home/Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
