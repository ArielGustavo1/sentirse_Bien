using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sentirse_Bien
{
    public partial class NvoTurno : Form
    {
        public List<Paciente> pacientes;
        public List<Servicio> servicios;
        //List<int> turnoHoras;
        public int index1, index2, index3;
        public string tipoServicio = string.Empty;
        TimeSpan horas = new TimeSpan(1, 0, 0);
        public DateTime dia = DateTime.Now;
        DateTime hoy = DateTime.Now;
        string auxHora = string.Empty;
        public bool pagado=false;

        public NvoTurno(List<Paciente> p, List<Servicio> s)
        {
            InitializeComponent();

            comboBox1.Items.Add("08" + ":00");
            comboBox1.Items.Add("09" + ":00");
            comboBox1.Items.Add("10" + ":00");
            comboBox1.Items.Add("11" + ":00");
            comboBox1.Items.Add("12" + ":00");
            comboBox1.Items.Add("16" + ":00");
            comboBox1.Items.Add("17" + ":00");
            comboBox1.Items.Add("18" + ":00");
            comboBox1.Items.Add("19" + ":00");
            comboBox1.Items.Add("20" + ":00");
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            label2.Text = "08:00";
            label1.Text = dia.ToString("d");
            foreach (var pa in p)//paciente
            {
                comboBox2.Items.Add(pa.nombre);
            }
            pacientes = p;
            servicios = s;
            foreach (var serv in servicios)//servicio
            {
                comboBox3.Items.Add(serv.nombreServicio);
            }
            //comboBox1.DataSource=turnoHoras;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)// dia del turno
        {
            if (monthCalendar1.SelectionStart >= (hoy - horas))
            {
                dia = monthCalendar1.SelectionStart;
                label1.Text = dia.ToString("d");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// hora del turno
        {
            label2.Text = comboBox1.SelectedItem.ToString();
            auxHora = label2.Text;
            if (comboBox1.SelectedIndex < 5) index1 = (comboBox1.SelectedIndex + 8);
            else index1 = (comboBox1.SelectedIndex + 11);


        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)// nombre del paciente
        {
            index2 = comboBox2.SelectedIndex;
            label4.Text = comboBox2.Text;

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)// nombre del servicio
        {
            index3 = comboBox3.SelectedIndex;
            label3.Text = comboBox3.Text;
            tipoServicio = label3.Text;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
            {

                this.DialogResult = DialogResult.OK;

            }
            else
            {
                this.Close();
            }
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex >= 0 && comboBox3.SelectedIndex >= 0)
            {
                Pago pago = new Pago(servicios[index3]);
                pago.ShowDialog();
                if (pago.DialogResult == DialogResult.OK)
                {
                    pagado = true;
                }
                else MessageBox.Show("No se ha podido ejecutar el cobro");
            }
            else MessageBox.Show("Seleccione el servicio y el paciente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAbonar_Click(sender, e);
        }
    }
}
