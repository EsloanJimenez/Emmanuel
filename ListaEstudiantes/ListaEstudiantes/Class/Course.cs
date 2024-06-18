using ListaEstudiantes.Entity;
using ListaEstudiantes.Interface;
using static System.Console;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ListaEstudiantes.Class
{
    public class Course<TEntity> : IPerson<TEntity> where TEntity : class
    {
        public IList<Person> Members { get; set; } = new List<Person>();
        string firstName, lastName;

        public async Task<TEntity> Get(int id)
        {
            return (TEntity)await Task.Run(() =>
            {
                return Members.Where(student => student.Id == id);
            });
        }

        public async Task<List<TEntity>> GetAll()
        {
            return (List<TEntity>)await Task.Run(() =>
            {
                return Members;
            });
        }

        public async Task Save<TEntity>(TEntity entity) where TEntity : Person
        {
            await Task.Run(() =>
            {
                var list = Members.ToList();
                list.Add(entity);
                Members = list;
            });
        }

        public async Task Update(int id)
        {
            WriteLine($"Editing student with id {id}");
            Write("First Name: \t");
            firstName = ReadLine();
            Write("Last Name: \t");
            lastName = ReadLine();

            var updateStudent = new Person { Id = id, FirstName = firstName, LastName = lastName };

            await Task.Run(() =>
            {
                var studentToUpdate = Members.FirstOrDefault(cd => cd.Id == id);
                if (studentToUpdate != null)
                {
                    studentToUpdate.FirstName = firstName;
                    studentToUpdate.LastName = lastName;
                } else
                {
                    WriteLine($"The student with the ID {id} was not found");
                }
            });
        }

        public async Task Delete(int id)
        {
            await Task.Run(() =>
            {
                var studentToDelete = Members.FirstOrDefault(cd => cd.Id == id);
                if (studentToDelete != null)
                {
                    Members.Remove(studentToDelete);
                    WriteLine($"The student with ID {id} was successfully removed.");
                } else
                {
                    WriteLine($"The student with ID {id} was not found");
                }
            });
        }
    }
}
