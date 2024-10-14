using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentirse_Bien
{
    internal class Turno
    {
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }

        public Turno(DateTime inicio, DateTime fin)
        {
            this.inicio = inicio;
            this.fin = fin;
        }
    }
}
