namespace sentirse_Bien
{
    partial class Pago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            btnCancelar = new Button();
            textBox1 = new TextBox();
            NroTarjeta = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            lblPrecio = new Label();
            lblPesos = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(548, 362);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 46);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(756, 362);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(655, 39);
            textBox1.TabIndex = 2;
            // 
            // NroTarjeta
            // 
            NroTarjeta.AutoSize = true;
            NroTarjeta.Location = new Point(35, 119);
            NroTarjeta.Name = "NroTarjeta";
            NroTarjeta.Size = new Size(210, 32);
            NroTarjeta.TabIndex = 3;
            NroTarjeta.Text = "Número de tarjeta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 232);
            label2.Name = "label2";
            label2.Size = new Size(216, 32);
            label2.TabIndex = 5;
            label2.Text = "Fecha Vencimiento";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 39);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 232);
            label3.Name = "label3";
            label3.Size = new Size(58, 32);
            label3.TabIndex = 7;
            label3.Text = "CCV";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(712, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 39);
            textBox3.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(51, 362);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(73, 32);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Saldo";
            // 
            // lblPesos
            // 
            lblPesos.AutoSize = true;
            lblPesos.Location = new Point(251, 362);
            lblPesos.Name = "lblPesos";
            lblPesos.Size = new Size(0, 32);
            lblPesos.TabIndex = 9;
            // 
            // Pago
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 492);
            Controls.Add(lblPesos);
            Controls.Add(lblPrecio);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(NroTarjeta);
            Controls.Add(textBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "Pago";
            Text = "Spa Pago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox textBox1;
        private Label NroTarjeta;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label lblPrecio;
        private Label lblPesos;
    }
}