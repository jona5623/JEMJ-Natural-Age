using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEMJ_Natural_Age.Models
{
    class Cita
    {

        public int Id_Cita { get; set; }

        public int Especialista { get; set; }

        public int Paciente { get; set; }

        public int Tratamiento { get; set; }

        public DateTime Fecha { get; set; }

        public virtual Especialista Especialista1 { get; set; }

        public virtual Paciente Paciente1 { get; set; }

        public virtual Tratamiento Tratamiento1 { get; set; }

        public Cita()
        {


        }

    }
}
