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
    public partial class NvoUser : Form
    {
        public string user;
        public string password;
        public string rePassword;
        public bool control = false;
        public NvoUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// registrarse
        {
            user=textBox1.Text;
            password=textBox2.Text;
            rePassword=textBox3.Text;
            if (user == "admin" || user == "secretaria") { user = ""; MessageBox.Show("Error en el registro\nUsuario Existente"); }
            else if (user == "" || password == "" || (password != rePassword)) MessageBox.Show("Error en el registro\nVuelva a intentar");
            else
            {
                MessageBox.Show("Registrado Exitosamente");
                control = true;
                this.Close();
            }
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
        }
    }
}
