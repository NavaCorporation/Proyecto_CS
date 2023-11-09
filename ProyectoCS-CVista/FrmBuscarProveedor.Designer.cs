namespace ProyectoCS_CVista
{
    partial class FrmBuscarProveedor
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
            panelBProveedor = new Panel();
            panel17 = new Panel();
            lbFondo2 = new Panel();
            dgvProveedor = new DataGridView();
            panel10 = new Panel();
            txtBuscarP = new TextBox();
            btnBuscarP = new Button();
            lbBuscar = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel13 = new Panel();
            panel16 = new Panel();
            panel15 = new Panel();
            panel14 = new Panel();
            panel12 = new Panel();
            panel11 = new Panel();
            btnProdu = new Button();
            btnEstadoP = new Button();
            btnFactu = new Button();
            btnBusque = new Button();
            btnProve = new Button();
            panel9 = new Panel();
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
            Código = new DataGridViewTextBoxColumn();
            Cédula = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Apellido2 = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Ruc = new DataGridViewTextBoxColumn();
            panelBProveedor.SuspendLayout();
            lbFondo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTyT.SuspendLayout();
            SuspendLayout();
            // 
            // panelBProveedor
            // 
            panelBProveedor.Controls.Add(panel17);
            panelBProveedor.Controls.Add(lbFondo2);
            panelBProveedor.Controls.Add(panel16);
            panelBProveedor.Controls.Add(panel15);
            panelBProveedor.Controls.Add(panel14);
            panelBProveedor.Controls.Add(panel12);
            panelBProveedor.Controls.Add(panel11);
            panelBProveedor.Controls.Add(btnProdu);
            panelBProveedor.Controls.Add(btnEstadoP);
            panelBProveedor.Controls.Add(btnFactu);
            panelBProveedor.Controls.Add(btnBusque);
            panelBProveedor.Controls.Add(btnProve);
            panelBProveedor.Controls.Add(panel9);
            panelBProveedor.Controls.Add(panel8);
            panelBProveedor.Controls.Add(panel6);
            panelBProveedor.Controls.Add(panel3);
            panelBProveedor.Controls.Add(panel2);
            panelBProveedor.Controls.Add(panelTyT);
            panelBProveedor.Location = new Point(2, 1);
            panelBProveedor.Margin = new Padding(0);
            panelBProveedor.Name = "panelBProveedor";
            panelBProveedor.Size = new Size(985, 617);
            panelBProveedor.TabIndex = 1;
            // 
            // panel17
            // 
            panel17.BackColor = SystemColors.ActiveCaptionText;
            panel17.Location = new Point(971, 147);
            panel17.Name = "panel17";
            panel17.Size = new Size(4, 443);
            panel17.TabIndex = 15;
            // 
            // lbFondo2
            // 
            lbFondo2.BackColor = Color.FromArgb(247, 244, 233);
            lbFondo2.Controls.Add(dgvProveedor);
            lbFondo2.Controls.Add(panel10);
            lbFondo2.Controls.Add(txtBuscarP);
            lbFondo2.Controls.Add(btnBuscarP);
            lbFondo2.Controls.Add(lbBuscar);
            lbFondo2.Controls.Add(textBox1);
            lbFondo2.Controls.Add(label1);
            lbFondo2.Controls.Add(panel13);
            lbFondo2.Location = new Point(217, 150);
            lbFondo2.Name = "lbFondo2";
            lbFondo2.Size = new Size(758, 440);
            lbFondo2.TabIndex = 13;
            lbFondo2.Paint += lbFondo2_Paint;
            // 
            // dgvProveedor
            // 
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { Código, Cédula, Apellido, Apellido2, Nombre, Ruc });
            dgvProveedor.Location = new Point(55, 154);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowTemplate.Height = 25;
            dgvProveedor.Size = new Size(643, 251);
            dgvProveedor.TabIndex = 15;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ActiveCaptionText;
            panel10.Location = new Point(1, 436);
            panel10.Name = "panel10";
            panel10.Size = new Size(754, 4);
            panel10.TabIndex = 14;
            panel10.Paint += panel10_Paint;
            // 
            // txtBuscarP
            // 
            txtBuscarP.Location = new Point(300, 97);
            txtBuscarP.Name = "txtBuscarP";
            txtBuscarP.Size = new Size(287, 23);
            txtBuscarP.TabIndex = 13;
            // 
            // btnBuscarP
            // 
            btnBuscarP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarP.Location = new Point(606, 74);
            btnBuscarP.Name = "btnBuscarP";
            btnBuscarP.Size = new Size(129, 63);
            btnBuscarP.TabIndex = 12;
            btnBuscarP.Text = "Buscar";
            btnBuscarP.UseVisualStyleBackColor = true;
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbBuscar.Location = new Point(38, 97);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(256, 21);
            lbBuscar.TabIndex = 11;
            lbBuscar.Text = "Buscar Proveedor, Mediante Cédula";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 23);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 10);
            label1.Name = "label1";
            label1.Size = new Size(379, 59);
            label1.TabIndex = 8;
            label1.Text = "Buscar Proveedor";
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.ActiveCaptionText;
            panel13.Location = new Point(3, 439);
            panel13.Name = "panel13";
            panel13.Size = new Size(748, 4);
            panel13.TabIndex = 7;
            // 
            // panel16
            // 
            panel16.BackColor = SystemColors.ActiveCaptionText;
            panel16.Location = new Point(979, 128);
            panel16.Name = "panel16";
            panel16.Size = new Size(4, 486);
            panel16.TabIndex = 9;
            // 
            // panel15
            // 
            panel15.BackColor = SystemColors.ActiveCaptionText;
            panel15.Location = new Point(193, 610);
            panel15.Name = "panel15";
            panel15.Size = new Size(788, 4);
            panel15.TabIndex = 8;
            // 
            // panel14
            // 
            panel14.BackColor = SystemColors.ActiveCaptionText;
            panel14.Location = new Point(214, 147);
            panel14.Name = "panel14";
            panel14.Size = new Size(757, 4);
            panel14.TabIndex = 8;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ActiveCaptionText;
            panel12.Location = new Point(958, 147);
            panel12.Name = "panel12";
            panel12.Size = new Size(4, 443);
            panel12.TabIndex = 13;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ActiveCaptionText;
            panel11.Location = new Point(214, 147);
            panel11.Name = "panel11";
            panel11.Size = new Size(4, 443);
            panel11.TabIndex = 6;
            // 
            // btnProdu
            // 
            btnProdu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnProdu.Location = new Point(16, 228);
            btnProdu.Name = "btnProdu";
            btnProdu.Size = new Size(158, 46);
            btnProdu.TabIndex = 11;
            btnProdu.Text = "Producto";
            btnProdu.UseVisualStyleBackColor = true;
            // 
            // btnEstadoP
            // 
            btnEstadoP.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstadoP.Location = new Point(16, 443);
            btnEstadoP.Name = "btnEstadoP";
            btnEstadoP.Size = new Size(158, 59);
            btnEstadoP.TabIndex = 10;
            btnEstadoP.Text = "Estado de Pedido";
            btnEstadoP.UseVisualStyleBackColor = true;
            // 
            // btnFactu
            // 
            btnFactu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnFactu.Location = new Point(16, 375);
            btnFactu.Name = "btnFactu";
            btnFactu.Size = new Size(158, 46);
            btnFactu.TabIndex = 9;
            btnFactu.Text = "Factura";
            btnFactu.UseVisualStyleBackColor = true;
            // 
            // btnBusque
            // 
            btnBusque.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBusque.Location = new Point(16, 304);
            btnBusque.Name = "btnBusque";
            btnBusque.Size = new Size(158, 46);
            btnBusque.TabIndex = 8;
            btnBusque.Text = "Busqueda";
            btnBusque.UseVisualStyleBackColor = true;
            // 
            // btnProve
            // 
            btnProve.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnProve.Location = new Point(16, 157);
            btnProve.Name = "btnProve";
            btnProve.Size = new Size(158, 46);
            btnProve.TabIndex = 6;
            btnProve.Text = "Proveedor";
            btnProve.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaptionText;
            panel9.Location = new Point(190, 130);
            panel9.Name = "panel9";
            panel9.Size = new Size(6, 486);
            panel9.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaptionText;
            panel8.Location = new Point(10, 607);
            panel8.Name = "panel8";
            panel8.Size = new Size(186, 9);
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
            // Código
            // 
            Código.HeaderText = "Código Proveedor";
            Código.Name = "Código";
            // 
            // Cédula
            // 
            Cédula.HeaderText = "Cédula ";
            Cédula.Name = "Cédula";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido(Paterno)";
            Apellido.Name = "Apellido";
            // 
            // Apellido2
            // 
            Apellido2.HeaderText = "Apellido(Materno)";
            Apellido2.Name = "Apellido2";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Ruc
            // 
            Ruc.HeaderText = "Ruc";
            Ruc.Name = "Ruc";
            // 
            // FrmBuscarProvedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 618);
            Controls.Add(panelBProveedor);
            Name = "FrmBuscarProvedor";
            Text = "FrmBuscarProvedor";
            Load += FrmBuscarProvedor_Load;
            panelBProveedor.ResumeLayout(false);
            lbFondo2.ResumeLayout(false);
            lbFondo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
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

        private Panel panelBProveedor;
        private Panel panel16;
        private Panel panel15;
        private Panel panel14;
        private Panel panel12;
        private Panel panel11;
        private Button btnProdu;
        private Button btnEstadoP;
        private Button btnFactu;
        private Button btnBusque;
        private Button btnProve;
        private Panel panel9;
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
        private Panel lbFondo2;
        private TextBox txtBuscarP;
        private Button btnBuscarP;
        private Label lbBuscar;
        private TextBox textBox1;
        private Label label1;
        private Panel panel13;
        private Panel panel17;
        private Panel panel10;
        private DataGridView dgvProveedor;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Cédula;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Apellido2;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Ruc;
    }
}