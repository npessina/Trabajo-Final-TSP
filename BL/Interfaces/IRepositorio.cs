using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CapaNegocio.Interfaces
{
    interface IRepositorio<T> where T : class
    {
        T Obtener(int id);
        IEnumerable<T> ObtenerTodos();
        IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado);

        T SingleOrDefault(Expression<Func<T, bool>> predicado);

        void Agregar(T entidad);
        void AgregarVarios(IEnumerable<T> entidades);

        void Borrar(T entidad);
        void BorrarVarios(IEnumerable<T> entidades);
    }
}
