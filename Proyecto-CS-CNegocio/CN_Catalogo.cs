using ProyectoCS_CDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CS_CNegocio
{
    public class CN_Catalogo
    {
        private CD_ManageCatalogo manejadorCatalogo = new CD_ManageCatalogo();

        private string nombreModelo, descripcion, nombreMarca, paisOrigen, nombreTipoProducto, nombreProducto;
        private int idProveedor, idModelo, idMarca, idTipoProducto;
        private decimal precioProducto;
        private byte[] fotoProducto, fotoMarca;

        public CN_Catalogo() {
            nombreModelo = string.Empty;
            descripcion = string.Empty;
            nombreMarca = string.Empty;
            paisOrigen = string.Empty;
            nombreTipoProducto = string.Empty;
            nombreProducto = string.Empty;
            idProveedor = 0;
            idModelo = 0;
            idMarca = 0;
            idTipoProducto = 0;
            precioProducto = 0;
        }

        public CN_Catalogo(string nombreModelo, string descripcion, string nombreMarca, string paisOrigen, string nombreTipoProducto, string nombreProducto, int idProveedor, int idModelo, int idMarca, int idTipoProducto, byte[] fotoProducto, byte[] fotoMarca) {
            this.nombreModelo = nombreModelo;
            this.descripcion = descripcion;
            this.nombreMarca = nombreMarca;
            this.paisOrigen = paisOrigen;
            this.nombreTipoProducto=nombreTipoProducto;
            this.nombreProducto = nombreProducto;
            this.idProveedor = idProveedor;
            this.idModelo = idModelo;
            this.idMarca = idMarca;
            this.idTipoProducto = idTipoProducto;
            this.fotoProducto = fotoProducto;
            this.fotoMarca = fotoMarca;
        }
        public string NombreModelo { get { return NombreModelo; } set { nombreModelo = value; } }
        public string Descripcion { get { return Descripcion; } set { descripcion = value; } }
        public string NombreMarca { get { return NombreMarca; } set { nombreMarca = value; } }
        public string PaisOrigen { get { return PaisOrigen; } set { paisOrigen = value; } }
        public string NombreTipoProducto { get { return NombreTipoProducto; } set { nombreTipoProducto = value; } }
        public string NombreProducto { get { return NombreProducto; } set { nombreProducto = value; } }
        public int IdProveedor { get { return IdProveedor; } set { idProveedor = value; } }
        public int IdModelo { get { return IdModelo; } set { idModelo = value; } }
        public int IdMarca { get { return IdMarca; } set { idMarca = value; } }
        public int IdTipoProducto { get { return IdTipoProducto; } set { idTipoProducto = value; } }
        public byte[] FotoProducto { get { return FotoProducto; } set { fotoProducto = value; } }
        public byte[] FotoMarca { get { return FotoMarca; } set { fotoMarca = value; } }

        public bool AgregarModelo() {
            return manejadorCatalogo.AgregarModelo( nombreModelo, descripcion);
        }

        public bool AgregarMarca()
        {
            return manejadorCatalogo.AgregarMarca(fotoMarca, nombreMarca, paisOrigen);
        }

        public bool AgregarTipoProducto() {
            return manejadorCatalogo.AgregarTipoProducto(nombreTipoProducto);
        }
        public bool InsertarProducto(){
            return manejadorCatalogo.AgregarAlCatalogo(fotoProducto, nombreProducto, precioProducto, idProveedor, idModelo, idMarca, idTipoProducto);
        }
    }
}
