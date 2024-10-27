using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using iText.Layout.Element;
using System.Diagnostics.Eventing.Reader;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sentirse_Bien
{
    public partial class Form1 : Form /*=====================================pantalla completa y tamaño de letra. Registro de usuario. registro de pagos. pdf. usuario saca turno, poder registrarse nvo user================================================*/
    {
        List<Servicio> servicios;
        //List<Profesional> profesionales;
        List<Paciente> pacientes;
        Profesional p = new Profesional("");
        string auxNombre = string.Empty;
        string tipoUser = string.Empty;
        Paciente nuevoPaciente;

        bool ctrlAgregar = false, ctrlPaciente = false, ctrlProfesional = false, ctrlTurno = false, ctrlServicio = false, ctrlBorrar = false;


        public Form1(string user, string pass)
        {
            InitializeComponent();
            //profesionales = new List<Profesional>();
            //this.WindowState = FormWindowState.Maximized;
            pacientes = new List<Paciente>();
            servicios = new List<Servicio>();
            nuevoPaciente = new Paciente();
            tableLayoutPanel1.Visible = false;
            pacientes = Formx.LeerListaP(@"D:\TUP\Cursado\Metodologia de sistemas\Clonado\bin\Debug\net8.0-windows\listaPacientes.json");
            servicios = Formx.LeerListaS(@"D:\TUP\Cursado\Metodologia de sistemas\Clonado\bin\Debug\net8.0-windows\listaServicios.json");
            if (user == "admin")
            {
                tipoUser = user;
            }
            else if (user == "secretaria")
            {
                tipoUser = user;
            }
            else if (user == "")//para pruebas
            {
                tipoUser = "admin";
            }
            else
            {
                tipoUser = "guest";
                string n;
                int edad;
                NvoPaciente nvoPaciente = new NvoPaciente();
                nvoPaciente.ShowDialog();
                if (nvoPaciente.DialogResult == DialogResult.OK)
                {
                    n = nvoPaciente.nombre;
                    edad = nvoPaciente.edad;
                    nuevoPaciente = new Paciente(n, edad);
                    pacientes.Add(nuevoPaciente);

                }

                nvoPaciente.Close();

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pacientes = Formx.LeerListaP(@"D:\TUP\Cursado\Metodologia de sistemas\Clonado\bin\Debug\net8.0-windows\listaPacientes.json");
            //servicios = Formx.LeerListaS(@"D:\TUP\Cursado\Metodologia de sistemas\Clonado\bin\Debug\net8.0-windows\listaServicios.json");
            /**pantalla completa y tamaño de letra. Registro de usuario. registro de pagos. pdf. usuario saca turno, poder registrarse nvo user*/

            //string prof1 = "Felicidad";
            //string prof2 = "Alegría";
            //string prof3 = "Bienestar";

            //string servicio1 = "masajes";
            //string servicio2 = "estética";
            //string servicio3 = "cuidado de piel";

            //Profesional pro1 = new Profesional(prof1);//masaje
            //Profesional pro2 = new Profesional(prof2);//estetica
            //Profesional pro3 = new Profesional(prof3);//cuidado de piel

            //Paciente p1 = new Paciente("Lindor", 23);
            //Paciente p2 = new Paciente("Rómulo", 24);
            //Paciente p3 = new Paciente("Ruperto", 42);
            //Paciente p4 = new Paciente("Isadora", 50);
            ////---------------------------------------------------------------
            //TimeSpan duracion = new TimeSpan(0, 50, 00);
            //DateTime inicio = new DateTime(2024, 11, 5, 18, 00, 00);
            //decimal precio = 12000;
            //Servicio s1 = new Servicio(pro1, servicio1, duracion, precio);

            //Turno t1 = new Turno(inicio, s1);
            //p1.turnos.Add(t1);
            ////---------------------------------------------------------------
            //duracion = new TimeSpan(0, 50, 00);
            //inicio = new DateTime(2024, 11, 5, 18, 00, 00);
            //precio = 15000;
            //Servicio s2 = new Servicio(pro2, servicio2, duracion, precio);

            //Turno t2 = new Turno(inicio, s2);
            //p2.turnos.Add(t2);
            ////---------------------------------------------------------------
            //duracion = new TimeSpan(0, 50, 0);
            //inicio = new DateTime(2024, 11, 7, 10, 00, 00);
            //precio = 18000;
            //Servicio s3 = new Servicio(pro3, servicio3, duracion, precio);
            //Turno t3 = new Turno(inicio, s3);
            //p3.turnos.Add(t3);
            ////---------------------------------------------------------------
            //inicio = new DateTime(2024, 10, 26, 17, 00, 00);

            //Turno t4 = new Turno(inicio, s2);
            //p4.turnos.Add(t4);
            ////---------------------------------------------------------------

            //pacientes.Add(p1);
            //pacientes.Add(p2);
            //pacientes.Add(p3);
            //pacientes.Add(p4);
            //servicios.Add(s1);
            //servicios.Add(s2);
            //servicios.Add(s3);

            //Form1.pLP(pacientes);
            //Form1.pLS(servicios);
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {

            if (tableLayoutPanel1.Visible)
            {
                if (tipoUser == "admin")
                {
                    tableLayoutPanel1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    btnService.Visible = false;
                    button6.Visible = true;
                    button7.Visible = false;
                    listBox1.Visible = false;
                    listBox2.Visible = false;
                    listBox3.Visible = false;
                    btnBorrar.Visible = false;
                    panel8.Visible = false;
                    btnPdf.Visible = false;
                    btnPago.Visible = false;
                    ctrloff();
                    limpiarListBox();
                    label9.Text = "Spa Sentirse bien... \r\nRelájate y revive en nuestro oasis de paz\r\n-masajes tratamientos cuidados-";
                }
                else if (tipoUser == "secretaria")
                {
                    tableLayoutPanel1.Visible = false;
                    button1.Visible = false;//profesional
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    btnService.Visible = false;//servicio
                    button6.Visible = true;
                    button7.Visible = false;
                    listBox1.Visible = false;
                    listBox2.Visible = false;
                    listBox3.Visible = false;
                    btnBorrar.Visible = false;
                    panel8.Visible = false;
                    btnPdf.Visible = false;
                    btnPago.Visible = false;
                    ctrloff();
                    limpiarListBox();
                    label9.Text = "Spa Sentirse bien... \r\nRelájate y revive en nuestro oasis de paz\r\n-masajes tratamientos cuidados-";
                }
                else if (tipoUser == "guest")
                {
                    tableLayoutPanel1.Visible = false;
                    //button1.Visible = false;//profesional
                    //button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    //btnService.Visible = false;//servicio
                    button6.Visible = true;
                    //button7.Visible = false;
                    listBox1.Visible = false;
                    listBox2.Visible = false;
                    listBox3.Visible = false;
                    //btnBorrar.Visible = false;
                    panel8.Visible = false;
                    //btnPdf.Visible = false;
                    ctrloff();
                    limpiarListBox();
                    label9.Text = "Spa Sentirse bien... \r\nRelájate y revive en nuestro oasis de paz\r\n-masajes tratamientos cuidados-";
                }

            }

            else
            {
                if (tipoUser == "admin")
                {
                    tableLayoutPanel1.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    btnService.Visible = true;
                    button6.Visible = false;
                    button7.Visible = true;
                    listBox1.Visible = true;
                    listBox2.Visible = true;
                    listBox3.Visible = true;
                    btnBorrar.Visible = true;
                    panel8.Visible = true;
                    btnPdf.Visible = true;
                    btnPago.Visible = true;
                    label9.Text = "Spa Sentirse bien... \r\nRelájate y revive en nuestro oasis de paz\r\n";
                }
                else if (tipoUser == "secretaria")
                {
                    tableLayoutPanel1.Visible = true;
                    //button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    //btnService.Visible = true;
                    button6.Visible = false;
                    button7.Visible = true;
                    listBox1.Visible = true;
                    listBox2.Visible = true;
                    listBox3.Visible = true;
                    btnBorrar.Visible = true;
                    panel8.Visible = true;
                    btnPdf.Visible = true;
                    btnPago.Visible = true;
                    label9.Text = "Spa Sentirse bien... \r\nRelájate y revive en nuestro oasis de paz\r\n";
                }
                else if (tipoUser == "guest")
                {
                    tableLayoutPanel1.Visible = true;
                    //button1.Visible = true;
                    //button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    //btnService.Visible = true;
                    button6.Visible = false;
                    //button7.Visible = true;
                    listBox1.Visible = true;
                    listBox2.Visible = true;
                    listBox3.Visible = true;
                    //btnBorrar.Visible = true;
                    panel8.Visible = true;
                    //btnPdf.Visible = true;
                    label9.Text = "Spa Sentirse bien... \r\nRelájate y revive en nuestro oasis de paz\r\n";
                }
            }


        }

        private void btnProfesional(object sender, EventArgs e)//btn nombreProfesionales
        {
            ctrloff();
            ctrlProfesional = true;
            limpiarListBox();

            listBox1.Items.Add("Lista de Profesionales: ");
            listBox1.Items.Add("");

            if (servicios.Count != 0)
            {
                HashSet<string> profesionales = new HashSet<string>();
                foreach (var serv in servicios)
                {
                    profesionales.Add(serv.profesional.nombre);

                }
                foreach (var pro in profesionales)
                {
                    listBox1.Items.Add(pro);
                }
                if (p.nombre != "") listBox1.Items.Add(p.nombre + " *sin servicio");
            }

        }
        private void btnPago_Click(object sender, EventArgs e)
        {
            int indice = -1;
            bool j = false;
            string nombre = string.Empty;
            if (ctrlPaciente && pacientes.Count > 0)
            {
                
                indice = listBox1.SelectedIndex;
                if (indice > 1) nombre = listBox1.SelectedItem.ToString();
                for (int i = 0; i < pacientes.Count; i++)
                {
                    if (pacientes[i].nombre == nombre)
                    {
                        j = true;
                        Pago pago = new Pago(pacientes[i]);
                        pago.ShowDialog();
                        if (pago.DialogResult == DialogResult.OK)
                        {
                            pacientes[i].saldo = 0;
                            MessageBox.Show("Pago Ejecutado");

                        }
                        //else MessageBox.Show("No se ha podido ejecutar el cobro");
                        break;
                    }
                    //else MessageBox.Show("Seleccione paciente");

                }
                if(!j) MessageBox.Show("Seleccione paciente");


            }
            

        }
        private void btnService_Click(object sender, EventArgs e)//btn 
        {
            ctrloff();
            ctrlServicio = true;
            limpiarListBox();
            listBox1.Items.Add("Lista de Servicios: ");
            listBox1.Items.Add("");
            if (servicios.Count != 0)
            {
                foreach (var p in servicios)
                {
                    listBox1.Items.Add(p.nombreServicio);


                }
            }
        }
        private void btnPaciente(object sender, EventArgs e)//btn pacientes
        {
            ctrloff();
            ctrlPaciente = true;
            limpiarListBox();
            listBox1.Items.Add("Lista de Pacientes: ");
            listBox1.Items.Add("");
            if (pacientes.Count != 0)
            {
                foreach (var p in pacientes)
                {
                    listBox1.Items.Add(p.nombre);
                    listBox1.Items.Add("edad: " + p.edad);
                    listBox1.Items.Add("");

                }
            }
        }

        private void btnTurno(object sender, EventArgs e)// btn turnos
        {
            int nro = 1;
            ctrloff();
            ctrlTurno = true;
            limpiarListBox();
            listBox1.Items.Add("Lista de Turnos: ");
            listBox1.Items.Add("");
            if (tipoUser != "guest" && pacientes.Count != 0)
            {

                foreach (var p in pacientes)
                {

                    int j = 0;
                    if (p.turnos.Count > 0)
                    {
                        listBox1.Items.Add(p.nombre);
                        foreach (Turno t in p.turnos)
                        {
                            //listBox1.Items.Add(nro);
                            listBox1.Items.Add(t.inicio.Day.ToString() + "/" + t.inicio.Month.ToString() + "/" + t.inicio.Year.ToString());
                            listBox1.Items.Add(t.inicio.Hour.ToString() + ":00");
                            nro++;
                            for (j = 0; j < t.servicios.Count; j++)
                            {
                                listBox1.Items.Add(t.servicios[j].nombreServicio);
                            }

                        }
                        listBox1.Items.Add("-----------------");
                    }

                }
            }
            else if (tipoUser == "guest")
            {
                if (nuevoPaciente.turnos.Count > 0)
                {
                    listBox1.Items.Add(nuevoPaciente.nombre);
                    foreach (var p in nuevoPaciente.turnos)
                    {
                        listBox1.Items.Add(p.inicio.ToString());
                    }
                }
                else listBox1.Items.Add("No hay turnos");
            }
        }
        

        private void btnAgregar(object sender, EventArgs e)// agregar nombreProfesionales, paciente y turno
        {
            if (ctrlProfesional)
            {
                string n, esp;
                //Profesional p;
                NvoProfesional nvoProfesional = new NvoProfesional();
                nvoProfesional.ShowDialog();
                if (nvoProfesional.DialogResult == DialogResult.OK)
                {
                    n = nvoProfesional.n;
                    esp = nvoProfesional.esp;
                    p = new Profesional(n);
                    //profesionales.Add(p);


                }
                else
                {
                    //MessageBox.Show("Error");
                }
                nvoProfesional.Close();
                btnProfesional(sender, e);


            }
            if (ctrlPaciente)
            {
                string n;
                int edad;
                Paciente p;
                NvoPaciente nvoPaciente = new NvoPaciente();
                nvoPaciente.ShowDialog();
                if (nvoPaciente.DialogResult == DialogResult.OK)
                {
                    n = nvoPaciente.nombre;
                    edad = nvoPaciente.edad;
                    p = new Paciente(n, edad);
                    pacientes.Add(p);

                }
                else
                {
                    //MessageBox.Show("Error");
                }
                nvoPaciente.Close();
                btnPaciente(sender, e);
            }
            if (ctrlServicio)
            {
                string nombreServicio;
                decimal precio;
                Servicio s;
                TimeSpan duracion;
                Profesional pro;

                NvoServicio nvoServicio = new NvoServicio(p, servicios);
                nvoServicio.ShowDialog();

                if (nvoServicio.DialogResult == DialogResult.OK)
                {
                    nombreServicio = nvoServicio.nombreServicio;
                    duracion = nvoServicio.duracion;
                    precio = nvoServicio.precio;
                    if (nvoServicio.nombreProfesional == p.nombre) { pro = new Profesional(p.nombre); p.nombre = ""; }
                    else { pro = servicios[nvoServicio.index].profesional; }
                    s = new Servicio(pro, nombreServicio, duracion, precio);
                    servicios.Add(s);

                }
                else
                {
                    //MessageBox.Show("Error");
                }
                nvoServicio.Close();
                btnService_Click(sender, e);
            }
            if (ctrlTurno)
            {

                DateTime _inicio, _fin;
                Servicio _s;
                NvoTurno nvoTurno = new NvoTurno(pacientes, servicios);
                nvoTurno.ShowDialog();
                if (nvoTurno.DialogResult == DialogResult.OK)
                {
                    _s = nvoTurno.servicios[nvoTurno.index3];
                    _inicio = new DateTime(nvoTurno.dia.Year, nvoTurno.dia.Month, nvoTurno.dia.Day, nvoTurno.index1, 0, 0);
                    _fin = _inicio + _s.duracion;
                    Turno t = new Turno(_inicio, _s);
                    pacientes[nvoTurno.index2].turnos.Add(t);
                    if(!nvoTurno.pagado)pacientes[nvoTurno.index2].saldo += _s.precio;
                    nvoTurno.Close();

                }


                btnTurno(sender, e);

            }
            Formx.pLP(pacientes);
            Formx.pLS(servicios);

        }

        private void btnSalir(object sender, EventArgs e)//salir
        {
            Application.Exit();
        }

        private void btnListarTodo(object sender, EventArgs e)// listar todo
        {
            ctrloff();
            //lbl1.Visible = false;
            //textBox1.Visible = false;
            limpiarListBox();
            listBox1.Items.Add(" Lista de Profesionales: ");
            listBox1.Items.Add("");
            if (servicios.Count != 0)
            {
                HashSet<string> profesionales = new HashSet<string>();
                foreach (var serv in servicios)
                {
                    profesionales.Add(serv.profesional.nombre);

                }
                foreach (var pro in profesionales)
                {
                    listBox1.Items.Add(pro);
                }
                if (p.nombre != "") listBox1.Items.Add(p.nombre + " *sin servicio");
            }

            listBox2.Items.Add("Lista de Pacientes: ");
            listBox2.Items.Add("");
            if (pacientes.Count != 0)
            {
                foreach (var p in pacientes)
                {
                    listBox2.Items.Add(p.nombre);
                }
            }
            listBox3.Items.Add("Lista de Turnos: ");
            listBox3.Items.Add("");
            if (pacientes.Count != 0)
            {
                foreach (var p in pacientes)
                {
                    //listBox3.Items.Add(p.nombre);
                    int j = 0;
                    foreach (Turno t in p.turnos)
                    {
                        listBox3.Items.Add(t.inicio.Day.ToString() + "/" + t.inicio.Month.ToString() + "/" + t.inicio.Year.ToString());
                        listBox3.Items.Add(t.inicio.Hour.ToString() + ":00");
                        listBox3.Items.Add("-----------------");

                    }
                }
            }
        }


        public void btnBorrar_Click(object sender, EventArgs e)
        {
            int indice = -1;
            string nombre = string.Empty;

            if (ctrlProfesional && servicios.Count > 0)
            {
                indice = listBox1.SelectedIndex;
                if (indice > 1) nombre = listBox1.SelectedItem.ToString();
                for (int i = 0; i < servicios.Count; i++)
                {
                    if (servicios[i].profesional.nombre == nombre)
                    {
                        servicios.Remove(servicios[i]);
                    }
                    else if (nombre == (p.nombre + " *sin servicio")) p = new Profesional("");
                    //MessageBox.Show(p.nombre);
                }

                btnProfesional(sender, e);


            }
            if (ctrlPaciente && pacientes.Count > 0)
            {

                indice = listBox1.SelectedIndex;
                if (indice > 1) nombre = listBox1.SelectedItem.ToString();
                for (int i = 0; i < pacientes.Count; i++)
                {
                    if (pacientes[i].nombre == nombre)
                    {
                        pacientes.Remove(pacientes[i]);
                    }

                }

                btnPaciente(sender, e);
            }
            if (ctrlServicio && servicios.Count > 0)
            {
                Turno t;
                indice = listBox1.SelectedIndex;
                if (indice > 1) nombre = listBox1.SelectedItem.ToString();
                for (int i = 0; i < servicios.Count; i++)
                {
                    if (servicios[i].nombreServicio == nombre)
                    {
                        servicios.Remove(servicios[i]);

                    }

                }
                //if (pacientes.Count > 0)
                //{
                //    for (int i = 0; i < pacientes.Count; i++)
                //    {
                //        if (pacientes[i].turnos.Count > 0)
                //        {
                //            for (int j = 0; j < pacientes[i].turnos.Count; j++)
                //            {
                //                MessageBox.Show("turnos"+ pacientes[i].turnos[j].servicios[0].nombreServicio);
                //                if (pacientes[i].turnos[j].servicios.Count > 0)
                //                {
                //                    for (int k = 0; k < pacientes[i].turnos[j].servicios.Count; k++)
                //                    {
                //                       if (nombre == pacientes[i].turnos[j].servicios[k].nombreServicio)
                //                        {
                //                          t = pacientes[i].turnos[j];
                //                            pacientes[i].turnos.Remove(t);
                //                        }
                //                    }
                //                }
                //            }
                //        }


                //    }
                //}


                btnService_Click(sender, e);
            }
            if (ctrlTurno && pacientes.Count > 0)
            {
                int indicador1 = -1;
                DateTime turno1;
                indice = listBox1.SelectedIndex;
                if (!ctrlBorrar)
                {
                    //indice = listBox1.SelectedIndex;
                    //MessageBox.Show("indice: "+indice.ToString());
                    if (indice > 1) nombre = listBox1.SelectedItem.ToString();
                    for (int i = 0; i < pacientes.Count; i++)
                    {
                        if (pacientes[i].nombre == nombre)
                        {
                            for (int j = 0; j < pacientes[i].turnos.Count; j++)
                            {
                                listBox2.Items.Add(pacientes[i].turnos[j].inicio);
                                auxNombre = pacientes[i].nombre;
                            }

                        }
                    }
                    ctrlBorrar = true;
                    if (indice == -1) ctrlBorrar = false;
                    if (listBox2.Items.Count == 0) ctrlBorrar = false;
                }
                else
                {
                    indicador1 = listBox2.SelectedIndex;
                    //MessageBox.Show("indicador1: "+indicador1.ToString());
                    if (indicador1 > -1)
                    {
                        foreach (Paciente p in pacientes)
                        {
                            if (auxNombre == p.nombre)
                            {
                                p.turnos.Remove(p.turnos[indicador1]);
                                auxNombre = string.Empty;
                            }
                        }
                        btnTurno(sender, e);

                        listBox2.Items.Clear();
                        for (int i = 0; i < pacientes.Count; i++)
                        {
                            if (pacientes[i].nombre == nombre)
                            {
                                for (int j = 0; j < pacientes[i].turnos.Count; j++)
                                {
                                    listBox2.Items.Add(pacientes[i].turnos[j].inicio);
                                }

                            }
                        }

                        ctrlBorrar = false;
                    }


                }




            }
            Formx.pLP(pacientes);
            Formx.pLS(servicios);
        }

        private void ctrloff()
        {
            ctrlProfesional = false;
            ctrlServicio = false;
            ctrlPaciente = false;
            ctrlTurno = false;
            ctrlAgregar = false;
            ctrlBorrar = false;
        }
        private void limpiarListBox()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

            if (ctrlProfesional)
            {
                HashSet<string> listaDeProfesionales = new HashSet<string>();
                List<string> list = new List<string>();
                if (servicios.Count != 0)
                {
                    //MessageBox.Show("servicios");
                    listaDeProfesionales.Add("Lista de Profesionales: ");
                    listaDeProfesionales.Add("");

                    foreach (var serv in servicios)
                    {
                        listaDeProfesionales.Add(serv.profesional.nombre);

                    }
                    if (p.nombre != "") listaDeProfesionales.Add(p.nombre + " *sin servicio");



                }
                else listaDeProfesionales.Add("No hay Profesionales");

                list = listaDeProfesionales.ToList();
                Formx.archivoPdf(list, "profesionales.pdf");

            }
            else if (ctrlPaciente)
            {
                HashSet<string> listaDePacientes = new HashSet<string>();
                List<string> list = new List<string>();
                if (pacientes.Count > 0)
                {

                    listaDePacientes.Add("Lista de Pacientes: ");
                    listaDePacientes.Add("");

                    foreach (var p in pacientes)
                    {
                        listaDePacientes.Add(p.nombre);


                    }


                }
                else listaDePacientes.Add("No hay Pacientes");

                list = listaDePacientes.ToList();
                Formx.archivoPdf(list, "pacientes.pdf");

            }
            else if (ctrlTurno) //---------------------------------------------------------------------------<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            {
                List<string> listaDeTurnos = new List<string>();
                List<string> list = new List<string>();
                if (pacientes.Count != 0)
                {

                    int nro = 1;
                    listaDeTurnos.Add("Lista de turnos: ");
                    listaDeTurnos.Add("");
                    foreach (var p in pacientes)
                    {

                        int j = 0;
                        if (p.turnos.Count > 0)
                        {

                            listaDeTurnos.Add(p.nombre);
                            foreach (Turno t in p.turnos)
                            {
                                //listBox1.Items.Add(nro);
                                listaDeTurnos.Add(t.inicio.Day.ToString() + "/" + t.inicio.Month.ToString() + "/" + t.inicio.Year.ToString());
                                listaDeTurnos.Add(t.inicio.Hour.ToString() + ":00");

                                for (j = 0; j < t.servicios.Count; j++)
                                {
                                    listaDeTurnos.Add(t.servicios[j].nombreServicio);
                                }

                            }
                            listaDeTurnos.Add(" -----------------");
                            nro++;
                        }
                        else listaDeTurnos.Add("No hay Turnos");

                        list = listaDeTurnos.ToList();
                    }


                }
                else listaDeTurnos.Add("No hay Pacientes");

                list = listaDeTurnos.ToList();
                Formx.archivoPdf(list, "turnos.pdf");
            }
            else if (ctrlServicio) //-------------------------------------------------------------------------------
            {
                List<string> list = new List<string>();
                HashSet<string> listaDeServicios = new HashSet<string>();
                if (servicios.Count != 0)
                {

                    listaDeServicios.Add("Lista de Servicios: ");
                    listaDeServicios.Add("");
                    foreach (var p in servicios)
                    {
                        listaDeServicios.Add(p.nombreServicio);

                    }


                }
                else listaDeServicios.Add("No hay Servicios");

                list = listaDeServicios.ToList();

                Formx.archivoPdf(list, "servicios.pdf");
            }
        }

        
    }
}

