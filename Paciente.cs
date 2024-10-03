using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentirse_Bien
{
    internal class Paciente
    {
        public string nombre { get; set; }
        public int edad { get; set; }
       
        public List<DateTime> turnos { get; set; }
        public Paciente(string n, int e) 
        {
            nombre = n;
            edad = e;
            turnos = new List<DateTime>();
        }
    }
}
