using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentirse_Bien
{
    public class Paciente
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public decimal saldo { get; set; }
       
        public List<Turno> turnos { get; set; } //fecha, hora, duracion total, lista de servicios, cliente, precio// promocion -> objeto con servicios 
        public Paciente()
        {
            nombre = string.Empty;
            edad = 0;
            turnos = new List<Turno>();
            saldo = 0;
        }
        public Paciente(string n, int e) 
        {
            nombre = n;
            edad = e;
            turnos = new List<Turno>();
            saldo = 0;
        }
        public Paciente(string n, int e, Turno turno)
        {
            nombre = n;
            edad = e;
            turnos = new List<Turno>();
            turnos.Add(turno);
            saldo = 0;
        }
    }
}
