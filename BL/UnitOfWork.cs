using CapaDatos;
using CapaNegocio.Interfaces;
using CapaNegocio.Repositorios;

namespace CapaNegocio
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly TuPilcheriaDbContext _contexto;
        public IRepositorioCategoria Categorias { get; private set; }
        public IRepositorioProducto Productos { get; private set; }

        public UnitOfWork(TuPilcheriaDbContext contexto)
        {
            _contexto = contexto;
            Categorias = new RepositorioCategoria(_contexto);
            Productos = new RepositorioProducto(_contexto);
        }

        public int Complete()
        {
            return _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
