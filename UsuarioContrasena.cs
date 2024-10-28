using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace sentirse_Bien
{
    public class UsuarioContrasena
    {
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public UsuarioContrasena() { usuario = ""; contrasena = ""; }  
        public UsuarioContrasena(string usuario, string contrasena) 
        {
            this.usuario = usuario; 
            this.contrasena = contrasena;
        }
    }
}
