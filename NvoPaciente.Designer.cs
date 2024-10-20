namespace sentirse_Bien
{
    partial class NvoPaciente
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
            textBox2 = new TextBox();
            lblEspecialidad = new Label();
            textBox1 = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(435, 346);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 46);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(329, 39);
            textBox2.TabIndex = 8;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(76, 184);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(71, 32);
            lblEspecialidad.TabIndex = 7;
            lblEspecialidad.Text = "Edad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 39);
            textBox1.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(76, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 32);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // NvoPaciente
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(textBox2);
            Controls.Add(lblEspecialidad);
            Controls.Add(textBox1);
            Controls.Add(lblNombre);
            Name = "NvoPaciente";
            Text = "NvoPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox textBox2;
        private Label lblEspecialidad;
        private TextBox textBox1;
        private Label lblNombre;
    }
}