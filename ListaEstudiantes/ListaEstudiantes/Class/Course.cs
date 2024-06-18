using ListaEstudiantes.Entity;
using ListaEstudiantes.Interface;
using static System.Console;

namespace ListaEstudiantes.Class
{
    public class Course<TEntity> : IPerson<TEntity> where TEntity : class
    {
        public IList<Person> Members { get; set; } = new List<Person>();
        string firstName, lastName;

        public List<Person> GetAll()
        {
            return Members.ToList();
        }

        public void Save<TEntity>(TEntity entity) where TEntity : Person
        {
            var idExist = Members.FirstOrDefault(cd => cd.Id == entity.Id);

            if (idExist != null)
            {
                WriteLine("There is already a user with this ID");
                WriteLine("Please enter another ID");
                return;
            }
            else
            {
                Members.Add(entity);
                WriteLine("\nSuccessfully added");
            }
        }

        public void Update(int id)
        {
            WriteLine($"Editing student with id {id}");
            Write("First Name: \t");
            firstName = ReadLine();
            Write("Last Name: \t");
            lastName = ReadLine();


            var studentToUpdate = Members.FirstOrDefault(cd => cd.Id == id);

            if (studentToUpdate != null)
            {
                studentToUpdate.FirstName = firstName;
                studentToUpdate.LastName = lastName;
            }
            else
            {
                WriteLine($"The student with the ID {id} was not found");
            }
        }

        public void Delete(int id)
        {
            var studentToDelete = Members.FirstOrDefault(cd => cd.Id == id);

            if (studentToDelete != null)
            {
                Members.Remove(studentToDelete);
                WriteLine($"The student with ID {id} was successfully removed.");
            }
            else
            {
                WriteLine($"The student with ID {id} was not found");
            }
        }
    }
}
