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
    public partial class Log : Form
    {
        string user = "";
        string pass = "";
        int count = 0;
        public Log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, pasword;
            usuario = textBox1.Text;
            pasword = textBox2.Text;
            lblUserPass.Text = "";
            if (count < 2)
            {
                if (usuario == user && pasword == pass)
                {
                    Form1 form = new Form1();
                    this.Hide();
                    form.ShowDialog();
                    
                    Application.Exit();
                    
                    
                }
                else
                {
                    count++;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    lblUserPass.Text = "Usuario o Contraseña incorrectos";

                }
                
            } else Application.Exit();
            

        }
    }
}
