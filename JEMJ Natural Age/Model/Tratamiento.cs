using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEMJ_Natural_Age.Models
{
    class Tratamiento
    {

        public int Id_Tratamiento { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }

        public Tratamiento()
        {

            Cita = new HashSet<Cita>();

        }

        
       

    }
}
