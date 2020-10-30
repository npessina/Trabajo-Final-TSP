using CapaDatos;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;

namespace CapaNegocio.Repositorios
{
    class RepositorioProducto : Repositorio<Producto>, IRepositorioProducto
    {
        public RepositorioProducto(TuPilcheriaDbContext contexto)
            : base(contexto)
        {
        }

        public IEnumerable<Producto> ObtenerProductosMasVendidos(int count)
        {
            //implementar
            throw new NotImplementedException();
        }

        public TuPilcheriaDbContext TuPilcheriaDbContext
        {
            get { return Contexto as TuPilcheriaDbContext; }
        }
    }
}
