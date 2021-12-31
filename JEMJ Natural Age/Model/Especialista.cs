using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEMJ_Natural_Age.Models
{
    class Especialista
    {

        public int Id_Especialista { get; set; }

        public int Id_Persona { get; set; }

        public string Especialidad { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }

        public virtual Persona Persona { get; set; }

        public Especialista()
        {

            Cita = new HashSet<Cita>();

        }


    }
}
