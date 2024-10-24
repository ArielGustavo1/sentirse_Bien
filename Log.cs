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
        string user = "admin";
        string pass = "admin";
        string user1 = "secretaria";
        string pass1 = "secretaria";
        string user2 = "";
        string pass2 = "";
        int count = 0;
        public Log()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, pasword;
            usuario = textBox1.Text;
            pasword = textBox2.Text;
            lblUserPass.Text = "";
            if (count < 2)
            {
                if ((usuario == user && pasword == pass) || (usuario == user1 && pasword == pass1) || (usuario == user2 && pasword == pass2))
                {
                    usuario = "admin";
                    Form1 form = new Form1(usuario);
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

            }
            else Application.Exit();


        }

        private void btnNvoUser_Click(object sender, EventArgs e)
        {
            string usuario=string.Empty;
            NvoUser nvoUser = new NvoUser();
            this.Hide();
            nvoUser.ShowDialog();
            if (nvoUser.control == true) 
            {
                usuario = nvoUser.user;
                //Application.Exit();
                Form1 form = new Form1(usuario);
                this.Hide();
                form.ShowDialog();
                
            }
            Application.Exit();
        }
    }
}
