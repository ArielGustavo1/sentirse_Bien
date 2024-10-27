namespace sentirse_Bien
{
    partial class NvoTurno
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
            monthCalendar1 = new MonthCalendar();
            btnAceptar = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnAbonar = new Button();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(518, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(655, 551);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 46);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(400, 40);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 442);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 442);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 56);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(400, 40);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(12, 270);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(400, 40);
            comboBox3.TabIndex = 7;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 534);
            label3.Name = "label3";
            label3.Size = new Size(97, 32);
            label3.TabIndex = 9;
            label3.Text = "Servicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 534);
            label4.Name = "label4";
            label4.Size = new Size(103, 32);
            label4.TabIndex = 8;
            label4.Text = "Paciente";
            // 
            // btnAbonar
            // 
            btnAbonar.Location = new Point(518, 364);
            btnAbonar.Name = "btnAbonar";
            btnAbonar.Size = new Size(287, 46);
            btnAbonar.TabIndex = 10;
            btnAbonar.Text = "Abonar con Credito";
            btnAbonar.UseVisualStyleBackColor = true;
            btnAbonar.Click += btnAbonar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(518, 435);
            button1.Name = "button1";
            button1.Size = new Size(287, 46);
            button1.TabIndex = 11;
            button1.Text = "Abonar con Débito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 350);
            label5.Name = "label5";
            label5.Size = new Size(401, 32);
            label5.TabIndex = 12;
            label5.Text = "Para abonar en el SPA pulsar aceptar";
            // 
            // NvoTurno
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 619);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(btnAbonar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnAceptar);
            Controls.Add(monthCalendar1);
            Name = "NvoTurno";
            Text = "NvoTurno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private Button btnAceptar;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label3;
        private Label label4;
        private Button btnAbonar;
        private Button button1;
        private Label label5;
    }
}