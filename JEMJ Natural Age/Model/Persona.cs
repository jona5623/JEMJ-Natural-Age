using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEMJ_Natural_Age.Models
{
    class Persona
    {
        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public virtual ICollection<Especialista> Especialista { get; set; }

        public virtual ICollection<Paciente> Paciente { get; set; }

        public Persona()
        {


        }

    }

}
