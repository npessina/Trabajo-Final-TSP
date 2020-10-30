using CapaDatos;
using System.Collections.Generic;

namespace CapaNegocio.Interfaces
{
    interface IRepositorioProducto : IRepositorio<Producto>
    {
        IEnumerable<Producto> ObtenerProductosMasVendidos(int count);
    }
}
