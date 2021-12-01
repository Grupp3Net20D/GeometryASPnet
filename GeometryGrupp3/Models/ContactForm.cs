using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometryGrupp3.Models
{
    public class ContactForm
    {
        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Email { get; set; }

        public string Msg { get; set; }

        public bool HasSubscribedToNewsLetter { get; set; }
    }
}
