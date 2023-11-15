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
            panelInicioS = new Panel();
            PanelSubLogin = new Panel();
            PanelSubLogin2 = new Panel();
            txtPass = new TextBox();
            lbPass = new Label();
            btnInicioS = new Button();
            lb = new Label();
            linkRe = new LinkLabel();
            txtUser = new TextBox();
            lbUser = new Label();
            panel16 = new Panel();
            panel15 = new Panel();
            panel8 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            lbFecha = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panelTyT = new Panel();
            lbPro = new Label();
            panelInicioS.SuspendLayout();
            PanelSubLogin.SuspendLayout();
            PanelSubLogin2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTyT.SuspendLayout();
            SuspendLayout();
            // 
            // panelInicioS
            // 
            panelInicioS.Controls.Add(PanelSubLogin);
            panelInicioS.Controls.Add(panel16);
            panelInicioS.Controls.Add(panel15);
            panelInicioS.Controls.Add(panel8);
            panelInicioS.Controls.Add(panel6);
            panelInicioS.Controls.Add(panel3);
            panelInicioS.Controls.Add(panel2);
            panelInicioS.Controls.Add(panelTyT);
            panelInicioS.Location = new Point(-1, -1);
            panelInicioS.Margin = new Padding(0);
            panelInicioS.Name = "panelInicioS";
            panelInicioS.Size = new Size(1004, 626);
            panelInicioS.TabIndex = 6;
            panelInicioS.Paint += panelBProveedor_Paint;
            // 
            // PanelSubLogin
            // 
            PanelSubLogin.BackColor = Color.FromArgb(255, 255, 192);
            PanelSubLogin.Controls.Add(PanelSubLogin2);
            PanelSubLogin.Location = new Point(264, 136);
            PanelSubLogin.Name = "PanelSubLogin";
            PanelSubLogin.Size = new Size(549, 465);
            PanelSubLogin.TabIndex = 11;
            // 
            // PanelSubLogin2
            // 
            PanelSubLogin2.BackColor = Color.FromArgb(247, 244, 233);
            PanelSubLogin2.Controls.Add(txtPass);
            PanelSubLogin2.Controls.Add(lbPass);
            PanelSubLogin2.Controls.Add(btnInicioS);
            PanelSubLogin2.Controls.Add(lb);
            PanelSubLogin2.Controls.Add(linkRe);
            PanelSubLogin2.Controls.Add(txtUser);
            PanelSubLogin2.Controls.Add(lbUser);
            PanelSubLogin2.Location = new Point(102, 17);
            PanelSubLogin2.Name = "PanelSubLogin2";
            PanelSubLogin2.Size = new Size(347, 432);
            PanelSubLogin2.TabIndex = 10;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(66, 180);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(189, 23);
            txtPass.TabIndex = 8;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPass.Location = new Point(66, 145);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(76, 21);
            lbPass.TabIndex = 7;
            lbPass.Text = "Password";
            // 
            // btnInicioS
            // 
            btnInicioS.Location = new Point(114, 294);
            btnInicioS.Name = "btnInicioS";
            btnInicioS.Size = new Size(105, 49);
            btnInicioS.TabIndex = 6;
            btnInicioS.Text = "Inicio Sesion";
            btnInicioS.UseVisualStyleBackColor = true;
            btnInicioS.Click += btnInicioS_Click_1;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(32, 245);
            lb.Name = "lb";
            lb.Size = new Size(124, 15);
            lb.TabIndex = 5;
            lb.Text = "Aun no tienes cuenta?";
            // 
            // linkRe
            // 
            linkRe.AutoSize = true;
            linkRe.Location = new Point(209, 245);
            linkRe.Name = "linkRe";
            linkRe.Size = new Size(87, 15);
            linkRe.TabIndex = 4;
            linkRe.TabStop = true;
            linkRe.Text = "Registrate Aqui";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(66, 91);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(189, 23);
            txtUser.TabIndex = 2;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUser.Location = new Point(66, 67);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(81, 21);
            lbUser.TabIndex = 0;
            lbUser.Text = "Username";
            // 
            // panel16
            // 
            panel16.BackColor = SystemColors.ActiveCaptionText;
            panel16.Location = new Point(979, 128);
            panel16.Name = "panel16";
            panel16.Size = new Size(5, 486);
            panel16.TabIndex = 9;
            // 
            // panel15
            // 
            panel15.BackColor = SystemColors.ActiveCaptionText;
            panel15.Location = new Point(193, 610);
            panel15.Name = "panel15";
            panel15.Size = new Size(792, 4);
            panel15.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaptionText;
            panel8.Location = new Point(10, 607);
            panel8.Name = "panel8";
            panel8.Size = new Size(970, 9);
            panel8.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(0, 130);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 486);
            panel6.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(0, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(985, 10);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 249, 224);
            panel2.Controls.Add(lbFecha);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(0, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 41);
            panel2.TabIndex = 1;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Location = new Point(890, 6);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(92, 30);
            lbFecha.TabIndex = 6;
            lbFecha.Text = "     09:21 am\r\n29 de junio 2023\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(106, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = Properties.Resources.cog;
            pictureBox3.Location = new Point(74, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Control;
            pictureBox4.Image = Properties.Resources.search;
            pictureBox4.Location = new Point(42, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.menu;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(982, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(3, 38);
            panel7.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 4);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(985, 4);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(0, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(3, 38);
            panel5.TabIndex = 3;
            // 
            // panelTyT
            // 
            panelTyT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTyT.BackColor = Color.FromArgb(246, 194, 19);
            panelTyT.Controls.Add(lbPro);
            panelTyT.Location = new Point(0, 0);
            panelTyT.Name = "panelTyT";
            panelTyT.Size = new Size(985, 83);
            panelTyT.TabIndex = 0;
            // 
            // lbPro
            // 
            lbPro.AutoSize = true;
            lbPro.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            lbPro.Location = new Point(252, 9);
            lbPro.Name = "lbPro";
            lbPro.Size = new Size(447, 59);
            lbPro.TabIndex = 0;
            lbPro.Text = "TUERCA Y TORNILLO";
            // 
            // FrMainClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 618);
            Controls.Add(panelInicioS);
            MaximizeBox = false;
            Name = "FrMainClient";
            Text = "Form1";
            Load += FrMainClient_Load;
            panelInicioS.ResumeLayout(false);
            PanelSubLogin.ResumeLayout(false);
            PanelSubLogin2.ResumeLayout(false);
            PanelSubLogin2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTyT.ResumeLayout(false);
            panelTyT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorLogin;
        private Panel panelInicioS;
        private Panel panel16;
        private Panel panel15;
        private Panel panel8;
        private Panel panel6;
        private Panel panel3;
        private Panel panel2;
        private Label lbFecha;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panelTyT;
        private Label lbPro;
        private Panel PanelSubLogin;
        private Panel PanelSubLogin2;
        private TextBox txtPass;
        private Label lbPass;
        private Button btnInicioS;
        private Label lb;
        private LinkLabel linkRe;
        private TextBox txtUser;
        private Label lbUser;
    }
}