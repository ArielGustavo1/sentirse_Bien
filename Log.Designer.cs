namespace sentirse_Bien
{
    partial class Log
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblUserPass = new Label();
            btnNvoUser = new Button();
            panel1 = new Panel();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(216, 375);
            button1.Name = "button1";
            button1.Size = new Size(1306, 58);
            button1.TabIndex = 0;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(216, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1306, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(216, 173);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(1306, 39);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(33, 75);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(33, 176);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // lblUserPass
            // 
            lblUserPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUserPass.AutoSize = true;
            lblUserPass.Font = new Font("Segoe UI", 6F);
            lblUserPass.Location = new Point(225, 258);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(0, 21);
            lblUserPass.TabIndex = 5;
            // 
            // btnNvoUser
            // 
            btnNvoUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnNvoUser.Location = new Point(216, 301);
            btnNvoUser.Name = "btnNvoUser";
            btnNvoUser.Size = new Size(1306, 58);
            btnNvoUser.TabIndex = 6;
            btnNvoUser.Text = "Nuevo Usuario";
            btnNvoUser.UseVisualStyleBackColor = true;
            btnNvoUser.Click += btnNvoUser_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logo_chico;
            panel1.Location = new Point(12, 652);
            panel1.Name = "panel1";
            panel1.Size = new Size(1788, 114);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("CommercialScript BT", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(420, 436);
            label3.Name = "label3";
            label3.Size = new Size(911, 204);
            label3.TabIndex = 8;
            label3.Text = "                    Spa Sentirse bien... \r\nRelájate y revive en nuestro oasis de paz\r\n          -masajes tratamientos cuidados-";
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 777);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnNvoUser);
            Controls.Add(lblUserPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Log";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spa Sentirse Bien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label lblUserPass;
        private Button btnNvoUser;
        private Panel panel1;
        private Label label3;
    }
}