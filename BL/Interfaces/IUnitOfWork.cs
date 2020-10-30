using System;

namespace CapaNegocio.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        IRepositorioCategoria Categorias { get; }
        IRepositorioProducto Productos { get; }
        int Complete();
    }
}
