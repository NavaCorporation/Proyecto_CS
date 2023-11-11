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
            panel9 = new Panel();
            lbUser = new Label();
            txtUser = new TextBox();
            linkRe = new LinkLabel();
            lb = new Label();
            btnInicioS = new Button();
            lbPass = new Label();
            txtPass = new TextBox();
            panelBProveedor = new Panel();
            panel9.SuspendLayout();
            panelBProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(247, 244, 233);
            panel9.Controls.Add(txtPass);
            panel9.Controls.Add(lbPass);
            panel9.Controls.Add(btnInicioS);
            panel9.Controls.Add(lb);
            panel9.Controls.Add(linkRe);
            panel9.Controls.Add(txtUser);
            panel9.Controls.Add(lbUser);
            panel9.Location = new Point(321, 72);
            panel9.Name = "panel9";
            panel9.Size = new Size(347, 432);
            panel9.TabIndex = 10;
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
            // txtUser
            // 
            txtUser.Location = new Point(66, 91);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(189, 23);
            txtUser.TabIndex = 2;
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
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(32, 245);
            lb.Name = "lb";
            lb.Size = new Size(124, 15);
            lb.TabIndex = 5;
            lb.Text = "Aun no tienes cuenta?";
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
            // txtPass
            // 
            txtPass.Location = new Point(66, 180);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(189, 23);
            txtPass.TabIndex = 8;
            // 
            // panelBProveedor
            // 
            panelBProveedor.Controls.Add(panel9);
            panelBProveedor.Location = new Point(-1, -1);
            panelBProveedor.Margin = new Padding(0);
            panelBProveedor.Name = "panelBProveedor";
            panelBProveedor.Size = new Size(992, 626);
            panelBProveedor.TabIndex = 6;
            panelBProveedor.Paint += panelBProveedor_Paint;
            // 
            // FrMainClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 618);
            Controls.Add(panelBProveedor);
            MaximizeBox = false;
            Name = "FrMainClient";
            Text = "Form1";
            Load += FrMainClient_Load;
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panelBProveedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorLogin;
        private Panel panel9;
        private TextBox txtPass;
        private Label lbPass;
        private Button btnInicioS;
        private Label lb;
        private LinkLabel linkRe;
        private TextBox txtUser;
        private Label lbUser;
        private Panel panelBProveedor;
    }
}