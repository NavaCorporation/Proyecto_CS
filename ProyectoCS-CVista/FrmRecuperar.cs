using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoCS_CDatos;
using ExceptionHandling;

namespace CapaPresentacion
{

    public partial class frmRecuperar : Form
    {
        private CD_ManageLogin negocioLogin = new CD_ManageLogin();
        private CE_Log Cexception = new CE_Log();
        public frmRecuperar()
        {
            InitializeComponent();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRecuperar_Click(object sender, EventArgs e)
        {
            string mail = tbMail.Text.Trim();

            if (string.IsNullOrWhiteSpace(mail))
            {
                MessageBox.Show("Por favor, ingrese su correo electrónico.");
                return;
            }

            if (!Cexception.VerificarCorreo(mail))
            {
                MessageBox.Show("El correo electrónico no está registrado en el sistema.");
                return;
            }

            string contrasenaRecuperada = Cexception.VerContrasena(mail);

            if (!string.IsNullOrEmpty(contrasenaRecuperada))
            {
                // Enviar el correo en un hilo secundario
                Task.Run(() => EnviarCorreoRecuperacion(mail, contrasenaRecuperada));

                MessageBox.Show("Se ha enviado un correo con la nueva contraseña. Por favor, revise su bandeja de entrada.");

                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo recuperar la contraseña para el correo electrónico proporcionado.");
            }
        }
        //Funcion
        private void EnviarCorreoRecuperacion(string correo_electronico, string contrasenaRecuperada)
        {
            //Vacio por el momento
            string correoEmpresa = "luisnavarrete2a89@gmail.com";
            string contrasenaEmpresa = "zzpwuxnzddslocie";
            string asunto = "Recuperación de contraseña";
            string cuerpo = $"Tu contraseña es: {contrasenaRecuperada}";

            using (MailMessage correo = new MailMessage(correoEmpresa, correo_electronico, asunto, cuerpo))
            {
                correo.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // Servidor SMTP y puerto de gmail 
                smtp.Credentials = new NetworkCredential(correoEmpresa, contrasenaEmpresa);
                smtp.EnableSsl = true;

                try
                {
                    smtp.Send(correo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar el correo de recuperación: " + ex.Message);
                }
            }
        }
    }

}
