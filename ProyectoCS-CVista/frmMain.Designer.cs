namespace CapaPresentacion
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            panelHijoForm = new Panel();
            panelLog = new Panel();
            gbLogin = new GroupBox();
            btSesion = new Button();
            registro = new Label();
            label2 = new Label();
            tbContrasena = new TextBox();
            tbUsername = new TextBox();
            label1 = new Label();
            errorLogin = new ErrorProvider(components);
            panelHijoForm.SuspendLayout();
            panelLog.SuspendLayout();
            gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorLogin).BeginInit();
            SuspendLayout();
            // 
            // panelHijoForm
            // 
            panelHijoForm.Controls.Add(panelLog);
            panelHijoForm.Location = new Point(12, 12);
            panelHijoForm.Name = "panelHijoForm";
            panelHijoForm.Size = new Size(964, 594);
            panelHijoForm.TabIndex = 0;
            // 
            // panelLog
            // 
            panelLog.BackColor = SystemColors.ActiveCaption;
            panelLog.Controls.Add(gbLogin);
            panelLog.Location = new Point(253, 14);
            panelLog.Name = "panelLog";
            panelLog.Size = new Size(500, 560);
            panelLog.TabIndex = 0;
            // 
            // gbLogin
            // 
            gbLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbLogin.BackColor = SystemColors.GradientInactiveCaption;
            gbLogin.Controls.Add(btSesion);
            gbLogin.Controls.Add(registro);
            gbLogin.Controls.Add(label2);
            gbLogin.Controls.Add(tbContrasena);
            gbLogin.Controls.Add(tbUsername);
            gbLogin.Controls.Add(label1);
            gbLogin.FlatStyle = FlatStyle.Popup;
            gbLogin.ForeColor = SystemColors.ButtonHighlight;
            gbLogin.Location = new Point(79, 76);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(342, 408);
            gbLogin.TabIndex = 1;
            gbLogin.TabStop = false;
            // 
            // btSesion
            // 
            btSesion.ForeColor = SystemColors.ActiveCaptionText;
            btSesion.Location = new Point(111, 252);
            btSesion.Name = "btSesion";
            btSesion.Size = new Size(129, 39);
            btSesion.TabIndex = 5;
            btSesion.Text = "Iniciar Sesion";
            btSesion.UseVisualStyleBackColor = true;
            btSesion.Click += btSesion_Click;
            // 
            // registro
            // 
            registro.AutoSize = true;
            registro.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            registro.ForeColor = SystemColors.Highlight;
            registro.Location = new Point(203, 334);
            registro.Name = "registro";
            registro.Size = new Size(87, 15);
            registro.TabIndex = 4;
            registro.Text = "Registrate Aqui";
            registro.Click += registro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(63, 334);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 3;
            label2.Text = "¿Aun no tienes cuenta? ";
            // 
            // tbContrasena
            // 
            tbContrasena.Location = new Point(63, 189);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.PasswordChar = '*';
            tbContrasena.PlaceholderText = "Contraseña";
            tbContrasena.Size = new Size(227, 23);
            tbContrasena.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.ForeColor = SystemColors.ControlText;
            tbUsername.Location = new Point(63, 124);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(227, 23);
            tbUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(132, 58);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // errorLogin
            // 
            errorLogin.ContainerControl = this;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 618);
            Controls.Add(panelHijoForm);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Votacion";
            //Load += frmMain_Load;
            panelHijoForm.ResumeLayout(false);
            panelLog.ResumeLayout(false);
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHijoForm;
        private Panel panelLog;
        private GroupBox gbLogin;
        private Label registro;
        private Label label2;
        private TextBox tbContrasena;
        private TextBox tbUsername;
        private Label label1;
        private Button btSesion;
        private ErrorProvider errorLogin;
    }
}