using System.Web;

namespace CapaPresentacion.ViewModels
{
    public class ProductoViewModel
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioProducto { get; set; }
        public HttpPostedFileBase RutaImagen { get; set; }
    }
}