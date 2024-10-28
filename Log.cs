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
        List<UsuarioContrasena> userPass;
        int control = -1;
        int count = 0;
        public Log()
        {
            InitializeComponent();
            userPass = new List<UsuarioContrasena>();
            //UsuarioContrasena us0 = new UsuarioContrasena();
            //us0.usuario = "secretaria";
            //us0.contrasena = "secretaria";
            //userPass.Add(us0);

            //UsuarioContrasena us1 = new UsuarioContrasena();
            //us1.usuario = "admin";
            //us1.contrasena = "admin";
            //userPass.Add(us1);

            //UsuarioContrasena us2 = new UsuarioContrasena();
            //us2.usuario = "invitado";
            //us2.contrasena = "invitado";
            //userPass.Add(us2);

            //Formx.escribirListaUserPass(userPass);
            userPass = Formx.LeerListaUserPass(@"D:\TUP\Cursado\Metodologia de sistemas\Clonado\bin\Debug\net8.0-windows\userPass.json");
            //MessageBox.Show(userPass[0].usuario);
            //MessageBox.Show(userPass[1].usuario);
            //MessageBox.Show(userPass[2].usuario);
            //MessageBox.Show(userPass[3].usuario);
            //MessageBox.Show(userPass[4].usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string usuario, pasword;
            usuario = textBox1.Text;
            password = textBox2.Text;
            lblUserPass.Text = "";
            if (count < 2)
            {
                foreach(var up in userPass)
                {
                    if (up.usuario == usuario && usuario == "admin" && password == "admin")
                    {
                        control = 0;
                    }
                    else if (up.usuario == usuario && usuario == "secretaria" && password == "secretaria")
                    {
                        control = 1;
                    }
                    else if (up.usuario == usuario && up.contrasena == password)
                    {
                        control = 2;
                        usuario = "invitado";
                    }
                    
                    

                }
                if (control>-1 && control <3)//sacar este ultimo ""
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
                    control = -1;
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
                UsuarioContrasena _userPass = new UsuarioContrasena(usuario, password);
                userPass.Add(_userPass);
                Formx.escribirListaUserPass(userPass);
                //Application.Exit();
                Form1 form = new Form1(usuario,password);
                this.Hide();
                form.ShowDialog();
                
            }
            Application.Exit();
            
        }
    }
}
