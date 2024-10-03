using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentirse_Bien
{
    internal class Profesional
    {
        public string nombre {get;set;}
        public string especialidad {get;set;}// lista de especialidad: belleza, masajes o tratamientos faciales, tratamientos corporales

        // lista de objetos servicios: id, nombre, precio, despcripción, duración y disponibilidad.
        //public List<Paciente> paciente {get;set;}
        public Profesional(string n, string e) 
        {
            nombre = n;
            especialidad = e;
            //paciente = new List<Paciente>();
        }
    }
}
