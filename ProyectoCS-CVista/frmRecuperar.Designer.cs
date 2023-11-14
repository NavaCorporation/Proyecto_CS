namespace CapaPresentacion
{
    partial class frmRecuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperar));
            label1 = new Label();
            btRegresar = new Button();
            label2 = new Label();
            tbMail = new TextBox();
            btRecuperar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(50, 28);
            label1.Name = "label1";
            label1.Size = new Size(242, 24);
            label1.TabIndex = 1;
            label1.Text = "¿Olvidaste tu contraseña?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btRegresar
            // 
            btRegresar.ForeColor = SystemColors.Desktop;
            btRegresar.Location = new Point(50, 244);
            btRegresar.Name = "btRegresar";
            btRegresar.Size = new Size(112, 41);
            btRegresar.TabIndex = 2;
            btRegresar.Text = "Regresar";
            btRegresar.UseVisualStyleBackColor = true;
            btRegresar.Click += btRegresar_Click;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(302, 62);
            label2.TabIndex = 3;
            label2.Text = "Introduce el mail con el que accedes a tu cuenta. En unos minutos recibiras un correo con una contraseña provisional.\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbMail
            // 
            tbMail.Location = new Point(50, 167);
            tbMail.Name = "tbMail";
            tbMail.PlaceholderText = "  Escribe tu Mail";
            tbMail.Size = new Size(242, 23);
            tbMail.TabIndex = 4;
            // 
            // btRecuperar
            // 
            btRecuperar.ForeColor = SystemColors.Desktop;
            btRecuperar.Location = new Point(180, 244);
            btRecuperar.Name = "btRecuperar";
            btRecuperar.Size = new Size(112, 41);
            btRecuperar.TabIndex = 5;
            btRecuperar.Text = "Solicitar recuperacion";
            btRecuperar.UseVisualStyleBackColor = true;
            btRecuperar.Click += btRecuperar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmRecuperar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 369);
            Controls.Add(btRecuperar);
            Controls.Add(btRegresar);
            Controls.Add(pictureBox1);
            Controls.Add(tbMail);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "frmRecuperar";
            Text = "Recuperar Contraseña";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btRegresar;
        private Label label2;
        private TextBox tbMail;
        private Button btRecuperar;
        private PictureBox pictureBox1;
    }
}