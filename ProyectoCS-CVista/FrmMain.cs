
using ExceptionHandling;
using Proyecto_CS_CNegocio;
using ProyectoCS_CVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CapaPresentacion
{
    public partial class frmMain : Form
    {
        public string usuarioCliente = string.Empty;
        private CN_Login manejarLogin = new CN_Login();
        private CE_Log Cexception = new CE_Log();
        private int intentosFallidos = 0;



        public frmMain()
        {
            InitializeComponent();
        }


        private Form activeForm = null;
        public void abrirHijoForm(Form formHijo)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formHijo;
            //Siempre que el panel hijo no sea de nivel superior se comportara como un control
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelHijoForm.Controls.Add(formHijo);
            panelHijoForm.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        //Abrir el formulario de Login para el modulo de Recuperar contraseña
        private Form activarFormulario = null;
        public void abrirMiniForm(Form miniForm)
        {
            if (activarFormulario != null)
                activarFormulario.Close();
            activarFormulario = miniForm;
            //Siempre que el panel hijo no sea de nivel superior se comportara como un control
            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            gbLogin.Controls.Add(miniForm);
            gbLogin.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }

        private void registro_Click(object sender, EventArgs e)
        {
            abrirHijoForm(new FrmCrearCliente());
        }

        private void btSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = tbUsername.Text;
            string contrasena = tbContrasena.Text;

            errorLogin.Clear(); // Limpia los errores existentes antes de realizar las validaciones.

            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                errorLogin.SetError(tbUsername, "Ingrese el nombre de usuario.");
                return;
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                errorLogin.SetError(tbContrasena, "Ingrese la contraseña.");
                return;
            }
            if (!Cexception.VerificarLog(nombreUsuario, contrasena))
            {
                usuarioCliente = nombreUsuario;

                intentosFallidos++;
                if (intentosFallidos >= 3)
                {
                    abrirMiniForm(new frmRecuperar());
                    intentosFallidos = 0;

                }
                errorLogin.SetError(tbUsername, "Usuario o contraseña incorrecta.");
                return;
            }
            

            if (!manejarLogin.VerificarLog(nombreUsuario, contrasena))
            {
                usuarioCliente = nombreUsuario;

                intentosFallidos++;
                if (intentosFallidos >= 3)
                {
                    abrirMiniForm(new frmRecuperar());
                    intentosFallidos = 0;
                }
                errorLogin.SetError(tbUsername, "Usuario o contraseña incorrecta.");
                return;
            }




            string perfilUsuario = Cexception.ModuloPorPerfil(nombreUsuario);
            string user = tbUsername.Text;
            switch (perfilUsuario.ToLower())
            {
                case "administrador":
                    abrirHijoForm(new FrmAdministrador(user));
                    break;

                case "cliente":
                    abrirHijoForm(new FrmCliente(user));
                    break;

                case "proveedor":
                    abrirHijoForm(new FrmProveedor(user));
                    break;

                default:
                    break;
            }

        }

        /*private void frmMain_Load(object sender, EventArgs e)
        {
            CN_Login loginManager = new CN_Login();
            bool creado = loginManager.CrearAdministradorPorDefecto();

            if (creado)
            {
                MessageBox.Show("Se ha creado un administrador por defecto.");
            }
        }*/

    }
}
