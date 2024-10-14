namespace sentirse_Bien
{
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
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnOpciones = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            textBox1 = new TextBox();
            lbl1 = new Label();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnOpciones);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 1173);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(109, 510);
            button7.Name = "button7";
            button7.Size = new Size(150, 46);
            button7.TabIndex = 11;
            button7.Text = "Listar Todo";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += btnListarTodo;
            // 
            // button6
            // 
            button6.BackColor = Color.Salmon;
            button6.Location = new Point(109, 903);
            button6.Name = "button6";
            button6.Size = new Size(150, 154);
            button6.TabIndex = 10;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnSalir;
            // 
            // button4
            // 
            button4.Location = new Point(109, 705);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 5;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += btnAgregar;
            // 
            // button3
            // 
            button3.Location = new Point(109, 410);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 4;
            button3.Text = "Turno";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += btnTurno;
            // 
            // button2
            // 
            button2.Location = new Point(109, 306);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 3;
            button2.Text = "Paciente";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += btnPaciente;
            // 
            // button1
            // 
            button1.Location = new Point(109, 202);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Profesional";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += btnProfesional;
            // 
            // btnOpciones
            // 
            btnOpciones.Anchor = AnchorStyles.Top;
            btnOpciones.Location = new Point(109, 98);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(150, 46);
            btnOpciones.TabIndex = 1;
            btnOpciones.Text = "Options";
            btnOpciones.UseVisualStyleBackColor = true;
            btnOpciones.Click += btnOpciones_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(78, 35);
            label1.Name = "label1";
            label1.Size = new Size(222, 45);
            label1.TabIndex = 0;
            label1.Text = "Herramientas";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lbl1);
            panel2.Controls.Add(listBox3);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(400, 0);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1755, 1173);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(1520, 1091);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 6;
            button5.Text = "Aceptar";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(614, 871);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 39);
            textBox1.TabIndex = 7;
            textBox1.Visible = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(294, 878);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 32);
            lbl1.TabIndex = 4;
            lbl1.Visible = false;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(1246, 3);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(497, 772);
            listBox3.TabIndex = 3;
            listBox3.Visible = false;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(725, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(515, 772);
            listBox2.TabIndex = 2;
            listBox2.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(257, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(462, 772);
            listBox1.TabIndex = 1;
            listBox1.Visible = false;
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
            tableLayoutPanel1.Size = new Size(254, 1173);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 882);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 288);
            panel5.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 45);
            label5.TabIndex = 5;
            label5.Text = "Order";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Info;
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 296);
            panel6.Name = "panel6";
            panel6.Size = new Size(248, 287);
            panel6.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 45);
            label3.TabIndex = 3;
            label3.Text = "Order";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 589);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 287);
            panel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 45);
            label4.TabIndex = 4;
            label4.Text = "Order";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 287);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 45);
            label2.TabIndex = 2;
            label2.Text = "Order";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2155, 1173);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Spa Sentirse Bien";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label label1;
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
        private TextBox textBox1;
        private Label lbl1;
        private Button button6;
        private Button button5;
        private Button button7;
    }
}
