namespace sentirse_Bien
{
    [Serializable]
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnPago = new Button();
            button6 = new Button();
            btnPdf = new Button();
            panel8 = new Panel();
            btnBorrar = new Button();
            btnService = new Button();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnOpciones = new Button();
            panel2 = new Panel();
            panel10 = new Panel();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            panel9 = new Panel();
            panel7 = new Panel();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnPago);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnPdf);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(btnBorrar);
            panel1.Controls.Add(btnService);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnOpciones);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 1570);
            panel1.TabIndex = 0;
            // 
            // btnPago
            // 
            btnPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPago.Location = new Point(3, 921);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(419, 72);
            btnPago.TabIndex = 16;
            btnPago.Text = "Pago/Saldo";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Visible = false;
            btnPago.Click += btnPago_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.MediumVioletRed;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.Image = Properties.Resources.logo_chico;
            button6.Location = new Point(38, 1157);
            button6.Name = "button6";
            button6.Size = new Size(349, 200);
            button6.TabIndex = 10;
            button6.Text = "Salir";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnSalir;
            // 
            // btnPdf
            // 
            btnPdf.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPdf.Location = new Point(3, 1024);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(419, 72);
            btnPdf.TabIndex = 15;
            btnPdf.Text = "Reporte pdf";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Visible = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // panel8
            // 
            panel8.BackgroundImage = Properties.Resources.logo_chico;
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 1363);
            panel8.Name = "panel8";
            panel8.Size = new Size(425, 207);
            panel8.TabIndex = 14;
            panel8.Visible = false;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBorrar.Location = new Point(3, 823);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(422, 66);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Visible = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnService
            // 
            btnService.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnService.Location = new Point(3, 349);
            btnService.Name = "btnService";
            btnService.Size = new Size(419, 72);
            btnService.TabIndex = 12;
            btnService.Text = "Servicio";
            btnService.UseVisualStyleBackColor = true;
            btnService.Visible = false;
            btnService.Click += btnService_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.Location = new Point(3, 628);
            button7.Name = "button7";
            button7.Size = new Size(422, 66);
            button7.TabIndex = 11;
            button7.Text = "Listar Todo";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += btnListarTodo;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(3, 726);
            button4.Name = "button4";
            button4.Size = new Size(422, 66);
            button4.TabIndex = 5;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += btnAgregar;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(6, 535);
            button3.Name = "button3";
            button3.Size = new Size(419, 72);
            button3.TabIndex = 4;
            button3.Text = "Turno";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += btnTurno;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(3, 443);
            button2.Name = "button2";
            button2.Size = new Size(419, 72);
            button2.TabIndex = 3;
            button2.Text = "Paciente";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += btnPaciente;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(3, 255);
            button1.Name = "button1";
            button1.Size = new Size(419, 72);
            button1.TabIndex = 2;
            button1.Text = "Profesional";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += btnProfesional;
            // 
            // btnOpciones
            // 
            btnOpciones.Anchor = AnchorStyles.Top;
            btnOpciones.BackColor = Color.MediumSeaGreen;
            btnOpciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpciones.Image = Properties.Resources.logo_chico;
            btnOpciones.Location = new Point(38, 24);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(349, 200);
            btnOpciones.TabIndex = 1;
            btnOpciones.Text = "Opciones";
            btnOpciones.TextAlign = ContentAlignment.BottomCenter;
            btnOpciones.UseVisualStyleBackColor = false;
            btnOpciones.Click += btnOpciones_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(425, 0);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(3069, 1570);
            panel2.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.BackColor = Color.White;
            panel10.Controls.Add(listBox3);
            panel10.Controls.Add(listBox2);
            panel10.Controls.Add(listBox1);
            panel10.Location = new Point(524, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(2545, 976);
            panel10.TabIndex = 13;
            // 
            // listBox3
            // 
            listBox3.BackColor = SystemColors.HighlightText;
            listBox3.BorderStyle = BorderStyle.None;
            listBox3.Font = new Font("Segoe UI", 18F);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 65;
            listBox3.Location = new Point(1754, 3);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(788, 910);
            listBox3.TabIndex = 3;
            listBox3.Visible = false;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.HighlightText;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Segoe UI", 18F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 65;
            listBox2.Location = new Point(880, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(868, 910);
            listBox2.TabIndex = 2;
            listBox2.Visible = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.HighlightText;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 18F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 65;
            listBox1.Location = new Point(0, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(874, 910);
            listBox1.TabIndex = 1;
            listBox1.Visible = false;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.logo_chico;
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(524, 1363);
            panel9.Name = "panel9";
            panel9.Size = new Size(2545, 207);
            panel9.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = SystemColors.HighlightText;
            panel7.Controls.Add(label9);
            panel7.Location = new Point(524, 967);
            panel7.Name = "panel7";
            panel7.Size = new Size(2545, 390);
            panel7.TabIndex = 11;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("CommercialScript BT", 45F);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(345, 15);
            label9.Name = "label9";
            label9.Size = new Size(1881, 552);
            label9.TabIndex = 11;
            label9.Text = "Spa Sentirse bien... \r\nRelájate y revive en nuestro oasis de paz \r\n-masajes tratamientos cuidados relax-\r\n\r\n";
            label9.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel5, 0, 3);
            tableLayoutPanel1.Controls.Add(panel6, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(524, 1570);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumSeaGreen;
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 1179);
            panel5.Name = "panel5";
            panel5.Size = new Size(518, 388);
            panel5.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("CommercialScript BT", 50F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(336, 154);
            label5.TabIndex = 5;
            label5.Text = "Bien";
            // 
            // panel6
            // 
            panel6.BackColor = Color.MediumSeaGreen;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 395);
            panel6.Name = "panel6";
            panel6.Size = new Size(518, 386);
            panel6.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("CommercialScript BT", 28F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(0, 261);
            label8.Name = "label8";
            label8.Size = new Size(217, 87);
            label8.TabIndex = 6;
            label8.Text = "Relax";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("CommercialScript BT", 28F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(0, 174);
            label7.Name = "label7";
            label7.Size = new Size(501, 87);
            label7.TabIndex = 5;
            label7.Text = "Cuidado de piel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("CommercialScript BT", 28F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(0, 87);
            label6.Name = "label6";
            label6.Size = new Size(428, 87);
            label6.TabIndex = 4;
            label6.Text = "Tratamientos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("CommercialScript BT", 28F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(263, 87);
            label3.TabIndex = 3;
            label3.Text = "Masajes";
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumVioletRed;
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 787);
            panel4.Name = "panel4";
            panel4.Size = new Size(518, 386);
            panel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("CommercialScript BT", 50F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(480, 154);
            label4.TabIndex = 4;
            label4.Text = "Sentirse";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumVioletRed;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(518, 386);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("CommercialScript BT", 60F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(328, 184);
            label2.TabIndex = 2;
            label2.Text = "Spa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(3494, 1570);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Spa Sentirse Bien";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Button btnOpciones;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private ListBox listBox2;
        private ListBox listBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private ListBox listBox3;
        private Button button6;
        private Button button7;
        private Button btnService;
        private Button btnBorrar;
        private Label label7;
        private Label label6;
        private Label label8;
        private Panel panel7;
        private Panel panel9;
        private Label label9;
        private Panel panel8;
        private Panel panel10;
        private Button btnPdf;
        private Button btnPago;
    }
}
