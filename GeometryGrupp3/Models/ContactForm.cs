using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeometryGrupp3.Models
{
    public class ContactForm
    {
        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Email { get; set; }

        public string Msg { get; set; }

        public bool HasSubscribedToNewsLetter { get; set; }

        public string Contact()
        {
            string input = "mailto:geometre@geometre.com?subject=Hej%20GeomeTre&body=Följande%20person%20har%20skrivit%20till%20dig%20via%20kontaktformuläret:\n\nNamn:" + Fname + "%20" + Lname + "%20" + "Email:" + Email + "Meddelande:" + Msg;
           
            //if (HasSubscribedToNewsLetter)
            //{
            //    input += "\nLägg till personen som prenumerant av nyhetsbrevet.";
            //}
            return input;
        }
    }
}
