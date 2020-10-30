using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Repositories
{
    class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected readonly DbContext Contexto;

        public Repositorio(DbContext contexto)
        {
            Contexto = contexto;
        }

        public void Agregar(T entity)
        {
            Contexto.Set<T>().Add(entity);
        }

        public void AgregarVarios(IEnumerable<T> entities)
        {
            Contexto.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicate)
        {
            return Contexto.Set<T>().Where(predicate);
        }

        public T Obtener(int id)
        {
            return Contexto.Set<T>().Find(id);
        }

        public IEnumerable<T> ObtenerTodos()
        {
            return Contexto.Set<T>().ToList();
        }

        public void Borrar(T entity)
        {
            Contexto.Set<T>().Remove(entity);
        }

        public void BorrarVarios(IEnumerable<T> entities)
        {
            Contexto.Set<T>().RemoveRange(entities);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return Contexto.Set<T>().SingleOrDefault(predicate);
        }
    }
}
