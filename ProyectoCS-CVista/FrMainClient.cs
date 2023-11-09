namespace ProyectoCS_CVista
{
    public partial class FrMainClient : Form
    {



         public FrMainClient()
         {
             InitializeComponent();
         }
     
        private void panelG1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInicioS_Click(object sender, EventArgs e)
        {

            string username = txtUser.Text;
            string password = txtPass.Text;
            errorLogin.Clear();


            if (string.IsNullOrWhiteSpace(username))
            {
                errorLogin.SetError(txtUser, "ingresar el nombre del usuario");
                return;

            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorLogin.SetError(txtPass, "ingresar la contraseña");
                return;

            }

        }
    }
}
