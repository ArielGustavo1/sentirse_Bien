using System.Collections.ObjectModel;

namespace sentirse_Bien
{
    public partial class Form1 : Form
    {
        List<Servicio> servicios;
        List<Profesional> profesional;
        List<Paciente> pacientes;
        bool ctrlAgregar = false,ctrlPaciente = false, ctrlProfesional = false, ctrlTurno = false, ctrlServicio=false;


        public Form1()
        {
            InitializeComponent();
            profesional = new List<Profesional>();
            pacientes = new List<Paciente>();
            servicios = new List<Servicio>();
            tableLayoutPanel1.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)// carga de datos temporales==========<<<<<<>>>>>>==================borrar despues de las pruebas
        {
            profesional.Add(new Profesional("Felicidad", "Masajes"));
            profesional.Add(new Profesional("Alegría", "Estética"));
            profesional.Add(new Profesional("Bienestar", "Cuidado_Piel"));
            Paciente p1 = new Paciente("Lindor", 23);
            p1.turnos.Add(new DateTime(2024, 11, 5, 18, 00, 00));
            Paciente p2 = new Paciente("Heraldo", 24);
            p2.turnos.Add(new DateTime(2024, 11, 6, 17, 00, 00));
            Paciente p3 = new Paciente("Rómulo", 35);
            p3.turnos.Add(new DateTime(2024, 11, 7, 08, 00, 00));
            Paciente p4 = new Paciente("Amado", 25);
            p4.turnos.Add(new DateTime(2024, 11, 8, 10, 00, 00));
            pacientes.Add(p1);
            pacientes.Add(p2);
            pacientes.Add(p3);
            pacientes.Add(p4);
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {

            if (tableLayoutPanel1.Visible)
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
                //lbl1.Visible = false;
                //label7.Visible = false;
                //lblTurno.Visible = false;
                //lbl2.Visible = false;
                //textBox1.Visible = false;
                //textBox2.Visible = false;
                //textBox3.Visible = false;
                //textBox4.Visible = false;
            }

            else
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
                //label6.Visible = true;
                //label7.Visible = true;
                //label8.Visible = true;
                //label9.Visible = true;
                //textBox1.Visible = true;
                //textBox2.Visible = true;
                //textBox3.Visible = true;
                //textBox4.Visible = true;
            }


        }

        private void btnProfesional(object sender, EventArgs e)//btn profesionales
        {
            ctrloff();
            ctrlProfesional = true;
            limpiarListBox();
            
            if (profesional.Count != 0)
            {
                {
                    foreach (var p in profesional)
                    {
                        listBox1.Items.Add(p.nombre);
                    }
                }
            }

        }

        private void btnServicio(object sender, EventArgs e)//btn pacientes
        {
            ctrloff();
            ctrlServicio = true;
            limpiarListBox();
            listBox1.Items.Add("Lista de Servicios: ");
            listBox1.Items.Add("");
            if (pacientes.Count != 0)
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
                }
            }
        }

        private void btnTurno(object sender, EventArgs e)// btn turnos
        {
            ctrloff();
            ctrlTurno = true;
            limpiarListBox();
            listBox1.Items.Add("Lista de Turnos: ");
            listBox1.Items.Add("");
            if (pacientes.Count != 0)
            {
                foreach (var p in pacientes)
                {
                    listBox1.Items.Add(p.nombre);
                    foreach (var t in p.turnos)
                    {
                        listBox1.Items.Add(t.ToString());
                    }
                    listBox1.Items.Add("-----------------");
                }
            }
        }
        

        private void btnAgregar(object sender, EventArgs e)// agregar profesional, paciente y turno
        {
            if (ctrlProfesional)
            {
                string n, esp;
                Profesional p;
                NvoProfesional nvoProfesional = new NvoProfesional();
                nvoProfesional.ShowDialog();
                if (nvoProfesional.DialogResult == DialogResult.OK)
                {
                    n=nvoProfesional.n;
                    esp = nvoProfesional.esp;
                    p = new Profesional(n,esp);
                    profesional.Add(p);
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }
                nvoProfesional.Close();
                btnProfesional(sender,e);
            }
            if (ctrlPaciente)
            {
                NvoPaciente nvoPaciente = new NvoPaciente();
                nvoPaciente.ShowDialog();
                btnPaciente(sender, e);
            }
            if (ctrlServicio)
            {
                NvoServicio nvoServicio = new NvoServicio();
                nvoServicio.ShowDialog();
                btnServicio(sender, e);
            }
            if (ctrlTurno)
            {
                NvoTurno nvoTurno = new NvoTurno();
                nvoTurno.ShowDialog();
                btnTurno(sender, e);
            }
            //ctrlAgregar = true;
            //lbl1.Visible = true;
            //label7.Visible = true;
            //label8.Visible = true;
            //lbl2.Visible = true;
            //btnListarTodo(sender, e);

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
            if (profesional.Count != 0)
            {
                {
                    foreach (var p in profesional)
                    {
                        listBox1.Items.Add(p.nombre);
                    }
                }
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
                    listBox3.Items.Add(p.nombre);
                    foreach (var t in p.turnos)
                    {
                        listBox3.Items.Add(t.ToString());
                    }
                    listBox3.Items.Add("-----------------");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string prof, pac, servicio,aux;
            string[] aux1=new string[6];
            int[] fecha = new int[6];
            DateTime dia;
            //prof = textBox1.Text;
            //servicio = textBox2.Text;
            //pac = textBox3.Text;
            //aux = textBox4.Text;
            //aux1 = aux.Split(',');

            for(int i=0;i<6;i++)
            {
                fecha[i]=int.Parse(aux1[i]);

            }
            dia = new DateTime(fecha[0], fecha[1], fecha[2], fecha[3], fecha[4], fecha[5]);
            
            
            //profesional.Add(new Profesional(prof,servicio));// ojo se puede agregar profesional nuevo o no
            //pacientes.Add

            btnListarTodo(sender, e);
        }
        private void apagarTexBox()
        {

        }
        private void ctrloff()
        {
            ctrlProfesional = false;
            ctrlServicio = false;
            ctrlPaciente = false;
            ctrlTurno = false;
            ctrlAgregar = false;
        }
        private void limpiarListBox()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

    }
}
