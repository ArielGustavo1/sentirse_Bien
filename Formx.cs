using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
//using iText.Kernel.Pdf;
//using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
//using iText.Layout;


namespace sentirse_Bien
{
    public partial class Form1
    {
        // Crear una paciente y una lista de personas
        //Paciente paciente = new paciente { Nombre = "Juan", Edad = 30 };
        //List<Persona> listaPersonas = new List<Persona>
        //{
        //    new Persona { Nombre = "Ana", Edad = 25 },
        //    new Persona { Nombre = "Luis", Edad = 35 }
        //};

        // Serializar y guardar
        
        public static void pP(Paciente paciente)
        {
            PersistirObjetoPac(paciente, "paciente.json");
        }
        public static void pLP(List<Paciente>pacientes)
        {
            PersistirListaPac(pacientes, "listaPacientes.json");
        }
        
        public static void PersistirObjetoPac(Paciente paciente, string archivo)
        {
            string jsonString = JsonSerializer.Serialize(paciente);
            File.WriteAllText(archivo, jsonString);
        }

        public static void PersistirListaPac(List<Paciente> pacientes, string archivo)
        {
            string jsonString = JsonSerializer.Serialize(pacientes);
            File.WriteAllText(archivo, jsonString);

        }
        public static void pS(Servicio servicio)
        {
            PersistirObjetoServ(servicio, "servicio.json");
        }
        public static void pLS(List<Servicio> servicios)
        {
            PersistirListaServ(servicios, "listaServicios.json");
        }

        public static void PersistirObjetoServ(Servicio servicio, string archivo)
        {
            string jsonString = JsonSerializer.Serialize(servicio);
            File.WriteAllText(archivo, jsonString);
        }

        public static void PersistirListaServ(List<Servicio> servicios, string archivo)
        {
            string jsonString = JsonSerializer.Serialize(servicios);
            File.WriteAllText(archivo, jsonString);

        }
        public static List<Paciente> LeerListaP(string archivo)
        {
            string jsonString = File.ReadAllText(archivo);
            return JsonSerializer.Deserialize<List<Paciente>>(jsonString);
        }
        public static List<Servicio> LeerListaS(string archivo)
        {
            string jsonString = File.ReadAllText(archivo);
            return JsonSerializer.Deserialize<List<Servicio>>(jsonString);
        }




        //static void pdf(List<string> datos)
        //{


        //    string rutaArchivo = "Listado.pdf";

        //    // Crear un nuevo documento PDF
        //    using (PdfWriter writer = new PdfWriter(rutaArchivo))
        //    {
        //        using (PdfDocument pdf = new PdfDocument(writer))
        //        {
        //            Document document = new Document(pdf);

        //            // Agregar cada línea de la lista al PDF
        //            foreach (var linea in datos)
        //            {
        //                document.Add(new Paragraph(linea));
        //            }

        //            document.Close();
        //        }
        //    }

        //    Console.WriteLine("PDF generado exitosamente en " + rutaArchivo);
        //}



    }

    
}

