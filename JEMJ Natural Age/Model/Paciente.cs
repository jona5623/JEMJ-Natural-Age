using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEMJ_Natural_Age.Models
{
    class Paciente
    {

        public int Id_Paciente { get; set; }

        public int Id_Persona { get; set; }

        public DateTime Fecha_Nacimineto { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }

        public virtual Persona Persona { get; set; }

        public Paciente()
        {
            Cita = new HashSet<Cita>();
        }

    }


}

