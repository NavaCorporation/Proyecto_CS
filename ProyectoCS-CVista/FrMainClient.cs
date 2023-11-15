using Proyecto_CS_CNegocio;

namespace ProyectoCS_CVista
{
    public partial class FrMainClient : Form
    {
        private CN_Login manejarLogin = new CN_Login();


        public FrMainClient()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void panelG1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void FrMainClient_Load(object sender, EventArgs e)
        {

        }

        private void panelBProveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicioS_Click_1(object sender, EventArgs e)
        {
            ///   FrmAdministrador frma = new FrmAdministrador();
            /// frma.Visible = true;


            string username = txtUser.Text;
            string password = txtPass.Text;

            errorLogin.Clear(); // Limpia los errores existentes antes de realizar las validaciones.

            if (string.IsNullOrWhiteSpace(username))
            {
                errorLogin.SetError(txtUser, "Ingrese el nombre de usuario.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorLogin.SetError(txtPass, "Ingrese la contraseña.");
                return;
            }

            /*if (!manejarLogin.VerificarLog(username, password))
            {
                  usuarioEstudiante = username;

                 intentosFallidos++;
                 if (intentosFallidos >= 3)
                 {
                     abrirMiniForm(new frmRecuperar());
                     intentosFallidos = 0;

                 }
                 errorLogin.SetError(tbUsername, "Usuario o contraseña incorrecta.");
                 return;
                 
            }*/



























        }


        private Form activeForm = null;

        public void abrir(Form formHijo)
        {

            if (activeForm != null) ;

            activeForm.Close();
            activeForm = formHijo;


            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            //Siempre que el panel hijo no sea de nivel superior se comportara como un control
            PanelSubLogin.Controls.Add(formHijo);
            PanelSubLogin.Tag = formHijo;
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
            PanelSubLogin2.Controls.Add(miniForm);
            PanelSubLogin2.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }


















    }
}
