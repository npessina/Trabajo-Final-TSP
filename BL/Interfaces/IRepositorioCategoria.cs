using CapaDatos;
using System.Collections.Generic;

namespace CapaNegocio.Interfaces
{
    interface IRepositorioCategoria : IRepositorio<Categoria>
    {
        IEnumerable<Categoria> ObtenerCategoriasMasVendidas(int count);
    }
}
