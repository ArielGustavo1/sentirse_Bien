using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentirse_Bien
{
    public class Turno
    {
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public List<Servicio>servicios { get; set; }

        public Turno()
        {
            inicio = DateTime.MinValue;
            fin = DateTime.MinValue;
            servicios = new List<Servicio>();
        }
        public Turno(DateTime inicio, Servicio servicio)
        {
            this.inicio = inicio;
            this.fin = inicio+servicio.duracion;
            servicios= new List<Servicio>();
            servicios.Add(servicio);
        }
    }
}
