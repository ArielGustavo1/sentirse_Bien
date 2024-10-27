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
        string usuario = string.Empty;
        string password = string.Empty;
        
        int count = 0;
        public Log()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string usuario, pasword;
            usuario = textBox1.Text;
            password = textBox2.Text;
            lblUserPass.Text = "";
            if (count < 2)
            {
                if ((usuario == "admin" && password == "admin") || (usuario == "secretaria" && password == "secretaria") || (usuario == "" && password == ""))//sacar este ultimo ""
                {
                    //usuario = "admin";
                    Form1 form = new Form1(usuario,password);
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
            //string usuario=string.Empty;
            NvoUser nvoUser = new NvoUser();
            this.Hide();
            nvoUser.ShowDialog();
            if (nvoUser.control == true) 
            {
                usuario = nvoUser.user;
                password = nvoUser.password; 
                //Application.Exit();
                Form1 form = new Form1(usuario,password);
                this.Hide();
                form.ShowDialog();
                
            }
            Application.Exit();
            
        }
    }
}
