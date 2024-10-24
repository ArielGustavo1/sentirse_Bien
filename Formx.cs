using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using iText.Layout;


namespace sentirse_Bien
{
    public partial class Formx
    {
        // Crear una paciente y una lista de personas
        //Paciente paciente = new paciente { Nombre = "Juan", Edad = 30 };
        //List<Persona> listaPersonas = new List<Persona>
        //{
        //    new Persona { Nombre = "Ana", Edad = 25 },
        //    new Persona { Nombre = "Luis", Edad = 35 }
        //};

        // Serializar y guardar
        public Formx()
        {

        }
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




        public static void archivoPdf(List<string> datos, string nombreArchivo)
        {
            string pdfPath = @"D:\TUP\\Cursado\Metodologia de sistemas\Clonado\";

            

            using (PdfWriter writer = new PdfWriter(pdfPath+nombreArchivo))
            {

            
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                Document document = new Document(pdf);

                // Agregar cada string como un párrafo al PDF
                foreach (var item in datos)
                {
                    document.Add(new Paragraph(item));
                }

                document.Close();
            }
            }
            
        }
        


    }

    
}

