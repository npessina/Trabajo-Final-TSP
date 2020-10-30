using CapaDatos;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;

namespace CapaNegocio.Repositorios
{
    class RepositorioCategoria : Repositorio<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoria(TuPilcheriaDbContext contexto)
            : base(contexto)
        {
        }

        public IEnumerable<Categoria> ObtenerCategoriasMasVendidas(int count)
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
