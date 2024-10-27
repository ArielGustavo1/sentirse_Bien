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
    public partial class Pago : Form
    {
        public Pago(Servicio servicio)
        {
            InitializeComponent();
            lblPesos.Text = servicio.precio.ToString();
            lblPrecio.Text = "Saldo";

        }
        public Pago(Paciente p)
        {
            InitializeComponent();
            lblPrecio.Text = p.nombre + ": Saldo";
            lblPesos.Text = p.saldo.ToString();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("No se pudo procesar el pago");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
