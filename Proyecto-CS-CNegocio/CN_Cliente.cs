namespace Proyecto_CS_CNegocio
{
    public class CN_Cliente
    {
        private CD_ManageCliente manejadorCliente = new CD_ManageCliente();

        private string nombreUsuario, contrasena, direccion, correoElectronico, telefono;

        public CN_Cliente()
        {
            nombreUsuario = string.Empty;
            contrasena = string.Empty;
            direccion = string.Empty;
            correoElectronico = string.Empty;
            telefono = string.Empty;
        }

        public CN_Cliente(string nombreUsuario, string contrasena, string direccion, string correoElectronico, string telefono)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
            this.telefono = telefono;
        }

        public string NombreUsuario { get {  return nombreUsuario; } set {  nombreUsuario = value; } }
        public string Contrasena { get {  return contrasena; } set {  contrasena = value; } }
        public string Direccion { get {  return direccion; } set {  direccion = value; } }
        public string CorreoElectronico { get {  return correoElectronico; } set {  correoElectronico = value; } }
        public string Telefono { get {  return telefono; } set {  telefono = value; } }

        public bool GuardarCliente()
        {
            return manejadorCliente.IngresarCliente(nombreUsuario, contrasena, direccion, correoElectronico, telefono);
        }

    }
}
