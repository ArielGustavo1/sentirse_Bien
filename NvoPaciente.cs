using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sentirse_Bien
{
    public partial class NvoPaciente : Form
    {
        public string nombre = string.Empty;
        public int edad;
        public NvoPaciente()
        {
            InitializeComponent();
        }
        

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            int numero;
            if (textBox1.Text != "")
            {
                nombre = textBox1.Text;
                bool esNumero = int.TryParse(textBox2.Text, out numero);
                if (esNumero)
                {
                    edad = numero;
                }
                else edad = 0;
                this.DialogResult = DialogResult.OK;
                //aceptar = true;
            }
            else
            {
                this.Close();
            }
        }
    }
}

