using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentirse_Bien
{
    internal class Servicio
    {
        public Profesional profesional { get; set; }
        public string nombreServicio { get; set; }
        public TimeSpan duracion { get; set; }
        public decimal precio { get; set; }

        public Servicio(Profesional profesional, string nombreServicio,TimeSpan duracion, decimal precio)
        {
            this.profesional = profesional;
            this.nombreServicio = nombreServicio;
            this.duracion = duracion;
            this.precio = precio;
        }
    }
}
