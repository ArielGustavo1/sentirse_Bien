namespace sentirse_Bien
{
    partial class NvoServicio
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
            label1 = new Label();
            cbProfesionales = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(459, 422);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 46);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 53);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 1;
            label1.Text = "Profesional";
            // 
            // cbProfesionales
            // 
            cbProfesionales.FormattingEnabled = true;
            cbProfesionales.Location = new Point(301, 52);
            cbProfesionales.Name = "cbProfesionales";
            cbProfesionales.Size = new Size(308, 40);
            cbProfesionales.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 39);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 132);
            label2.Name = "label2";
            label2.Size = new Size(192, 32);
            label2.TabIndex = 4;
            label2.Text = "Nombre Servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 217);
            label3.Name = "label3";
            label3.Size = new Size(172, 32);
            label3.TabIndex = 6;
            label3.Text = "Duración [min]";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 39);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 304);
            label4.Name = "label4";
            label4.Size = new Size(79, 32);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 304);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 39);
            textBox3.TabIndex = 7;
            // 
            // NvoServicio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 546);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(cbProfesionales);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Name = "NvoServicio";
            Text = "NvoServicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label label1;
        private ComboBox cbProfesionales;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
    }
}