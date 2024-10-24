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
    public partial class NvoProfesional : Form
    {
        public string n=string.Empty, esp = string.Empty;
        public bool aceptar = false;
        public NvoProfesional()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n=textBox1.Text;
                esp = "";
                this.DialogResult=DialogResult.OK;
                //aceptar = true;
            }
            else
            {
                this.Close();
            }
           
        }
    }
}
