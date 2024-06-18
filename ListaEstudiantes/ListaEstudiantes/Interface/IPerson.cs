using ListaEstudiantes.Entity;

namespace ListaEstudiantes.Interface
{
    public interface IPerson<TEntity> where TEntity : class
    {
        void Save<TEntity>(TEntity entity) where TEntity : Person;
        List<Person> GetAll();
        void Update(int id);
        void Delete(int id);
    }
}
