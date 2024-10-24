using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sentirse_Bien
{
    public partial class NvoServicio : Form
    {
        //public List<string> nombreProfesionales;
        bool varTiempo=false, varGuita=false;
        public string nombreProfesional, nombreServicio;
        public decimal precio;
        
        public int index = -1, temp;
        public TimeSpan duracion;
        public NvoServicio(Profesional p, List<Servicio>s)
        {
            InitializeComponent();

            // = nombreProfesionales;
            HashSet<string> profesionales = new HashSet<string>();
            foreach (var serv in s)
            {
                profesionales.Add(serv.profesional.nombre);

            }
            foreach (var pro in profesionales)
            {
                cbProfesionales.Items.Add(pro);
            }
            if(p.nombre!="") cbProfesionales.Items.Add(p.nombre);
            cbProfesionales.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != ""&& textBox2.Text != ""&& textBox3.Text != "")
            {
                nombreServicio = textBox1.Text;
                varTiempo = int.TryParse(textBox2.Text, out temp);
                //varTiempo = TimeSpan.TryParse(textBox2.Text,out TimeSpan result);
                varGuita = decimal.TryParse(textBox3.Text, out decimal resul1);
                if (varTiempo && varGuita && cbProfesionales.SelectedIndex!=-1)
                {
                    duracion=new TimeSpan(0,0,temp,0);
                    precio=resul1;
                    index = cbProfesionales.SelectedIndex;
                    nombreProfesional = cbProfesionales.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.Close();
                }

                
                //aceptar = true;
            }
            else
            {
                this.Close();
            }
        }

        
    }
}
