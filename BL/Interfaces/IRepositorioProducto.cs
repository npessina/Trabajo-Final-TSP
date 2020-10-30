using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{
    interface IRepositorioProducto : IRepositorio<Product>
    {
        IEnumerable<Product> ObtenerProductosMasVendidos(int count);
    }
}
