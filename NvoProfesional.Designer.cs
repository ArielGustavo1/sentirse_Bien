namespace sentirse_Bien
{
    partial class NvoProfesional
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
            lblNombre = new Label();
            textBox1 = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(75, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 32);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 39);
            textBox1.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(434, 351);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 46);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // NvoProfesional
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(textBox1);
            Controls.Add(lblNombre);
            Name = "NvoProfesional";
            Text = "NvoProfesional";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox textBox1;
        private Button btnAceptar;
    }
}