using ListaEstudiantes.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace ListaEstudiantes.Interface
{
    public interface IPerson<TEntity> where TEntity : class
    {
        Task Save<TEntity>(TEntity entity) where TEntity : Person;
        Task<TEntity> Get(int id);
        Task<List<TEntity>> GetAll();
        Task Update(int id);
        Task Delete(int id);
    }
}
