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
        List<UsuarioContrasena> userPass;
        public string user;
        public string password;
        public string rePassword;
        public bool control = false;
        bool j = false;
        public NvoUser()
        {
            InitializeComponent();
            userPass = new List<UsuarioContrasena>();
            userPass = Formx.LeerListaUserPass(@"D:\TUP\Cursado\Metodologia de sistemas\Clonado\bin\Debug\net8.0-windows\userPass.json");
        }

        private void button1_Click(object sender, EventArgs e)// registrarse
        {
            user=textBox1.Text;
            password=textBox2.Text;
            rePassword=textBox3.Text;
            foreach (var i in userPass)
            {
                if (i.usuario == user) j = true;
            }
            if (user == "admin" || user == "secretaria") { user = ""; MessageBox.Show("Error en el registro\nUsuario Existente"); }
            else if (user == "" || password == "" || (password != rePassword)) MessageBox.Show("Error en el registro\nVuelva a intentar");
            else if(j) MessageBox.Show("Error en el registro\nUsuario Existente");
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
