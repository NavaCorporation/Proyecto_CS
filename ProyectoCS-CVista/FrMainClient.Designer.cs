namespace ProyectoCS_CVista
{
    partial class FrMainClient
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
            panelG1 = new Panel();
            panelLogin1 = new Panel();
            panelLogin2 = new Panel();
            txtPass = new TextBox();
            txtUser = new TextBox();
            lbPass = new Label();
            lbUser = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            btnInicioS = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelG1.SuspendLayout();
            panelLogin1.SuspendLayout();
            panelLogin2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelG1
            // 
            panelG1.BorderStyle = BorderStyle.FixedSingle;
            panelG1.Controls.Add(panelLogin1);
            panelG1.Location = new Point(12, 12);
            panelG1.Name = "panelG1";
            panelG1.Size = new Size(1004, 657);
            panelG1.TabIndex = 0;
            panelG1.Paint += panelG1_Paint;
            // 
            // panelLogin1
            // 
            panelLogin1.BackColor = Color.FromArgb(246, 194, 19);
            panelLogin1.BorderStyle = BorderStyle.FixedSingle;
            panelLogin1.Controls.Add(panelLogin2);
            panelLogin1.Location = new Point(271, 43);
            panelLogin1.Name = "panelLogin1";
            panelLogin1.Size = new Size(500, 570);
            panelLogin1.TabIndex = 0;
            // 
            // panelLogin2
            // 
            panelLogin2.BackColor = Color.FromArgb(247, 244, 233);
            panelLogin2.BorderStyle = BorderStyle.FixedSingle;
            panelLogin2.Controls.Add(txtPass);
            panelLogin2.Controls.Add(txtUser);
            panelLogin2.Controls.Add(lbPass);
            panelLogin2.Controls.Add(lbUser);
            panelLogin2.Controls.Add(linkLabel1);
            panelLogin2.Controls.Add(label3);
            panelLogin2.Controls.Add(btnInicioS);
            panelLogin2.Controls.Add(pictureBox1);
            panelLogin2.Controls.Add(label1);
            panelLogin2.Location = new Point(79, 27);
            panelLogin2.Name = "panelLogin2";
            panelLogin2.Size = new Size(342, 497);
            panelLogin2.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(108, 282);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(172, 23);
            txtPass.TabIndex = 11;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(108, 233);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(172, 23);
            txtUser.TabIndex = 10;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbPass.Location = new Point(25, 283);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(84, 19);
            lbPass.TabIndex = 9;
            lbPass.Text = "Contraseña";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.Location = new Point(25, 231);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(76, 19);
            lbUser.TabIndex = 8;
            lbUser.Text = "Username";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(240, 395);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrate Aqui";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 393);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 6;
            label3.Text = "Aun no tienes cuenta ?";
            // 
            // btnInicioS
            // 
            btnInicioS.BackColor = Color.FromArgb(246, 194, 19);
            btnInicioS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicioS.Location = new Point(107, 323);
            btnInicioS.Name = "btnInicioS";
            btnInicioS.Size = new Size(146, 55);
            btnInicioS.TabIndex = 4;
            btnInicioS.Text = "Inicio Sesion";
            btnInicioS.UseVisualStyleBackColor = false;
            btnInicioS.Click += btnInicioS_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoLogin;
            pictureBox1.Location = new Point(108, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 157);
            label1.Name = "label1";
            label1.Size = new Size(158, 59);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // FrMainClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 681);
            Controls.Add(panelG1);
            Name = "FrMainClient";
            Text = "Form1";
            panelG1.ResumeLayout(false);
            panelLogin1.ResumeLayout(false);
            panelLogin2.ResumeLayout(false);
            panelLogin2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelG1;
        private Panel panelLogin1;
        private Panel panelLogin2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnInicioS;
        private LinkLabel linkLabel1;
        private Label lbPass;
        private Label lbUser;
        private TextBox txtUser;
        private TextBox txtPass;
        private ErrorProvider errorLogin;
    }
}