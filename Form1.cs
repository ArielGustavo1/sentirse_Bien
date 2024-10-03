using System.Collections.ObjectModel;

namespace sentirse_Bien
{
    public partial class Form1 : Form
    {

        List<Profesional> profesional;
        List<Paciente> pacientes;


        public Form1()
        {
            InitializeComponent();
            profesional = new List<Profesional>();
            pacientes = new List<Paciente>();
            tableLayoutPanel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)// carga de datos temporales==========<<<<<<>>>>>>==================borrar despues de las pruebas
        {
            profesional.Add(new Profesional("Felicidad","Masajes"));
            profesional.Add(new Profesional("Alegría","Estética"));
            profesional.Add(new Profesional("Bienestar","Cuidado_Piel"));
            Paciente p1 = new Paciente("Lindor", 23);  
            p1.turnos.Add(new DateTime(2024,11,5,18,00,00));
            Paciente p2 = new Paciente("Heraldo", 24); 
            p2.turnos.Add(new DateTime(2024, 11, 6,17,00,00));
            Paciente p3 = new Paciente("Rómulo", 35);  
            p3.turnos.Add(new DateTime(2024, 11, 7,08,00,00));
            Paciente p4 = new Paciente("Amado", 25);  
            p4.turnos.Add(new DateTime(2024, 11, 8,10,00,00));
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
                button5.Visible = false;
                button6.Visible = true;
                listBox1.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }

            else
            {
                tableLayoutPanel1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = false;
                listBox1.Visible = true;
                listBox2.Visible = true;
                listBox3.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)//btn profesionales
        {
            listBox1.Items.Clear();
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

        }


        private void button2_Click(object sender, EventArgs e)//btn pacientes
        {
            listBox1.Items.Clear();
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

        private void button3_Click(object sender, EventArgs e)// btn turnos
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Lista de Turnos: ");
            listBox1.Items.Add("");
            if (pacientes.Count != 0)
            {
                foreach (var p in pacientes)
                {
                    listBox1.Items.Add(p.nombre);
                    foreach(var t in p.turnos)
                    {
                        listBox1.Items.Add(t.ToString());
                    }
                    listBox1.Items.Add("-----------------");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)// agregar profesional, paciente y turno
        {

        }

        private void button6_Click(object sender, EventArgs e)//salir
        {
            Application.Exit();
        }
    }
}
