using ListaEstudiantes.Class;
using ListaEstudiantes.Entity;
using static System.Console;

var menu = new Menu();
var repeat = new Repeat();
var students = new Course<Person>();

WriteLine("Welcom to list students \n");

int id, Op = 0;
string firstName, lastName;

do
{
    menu.Option();
    Op = int.Parse(Console.ReadLine());

    switch (Op)
    {
        case 1:
            Write("Id: \t\t");
            id = int.Parse(ReadLine());

            Write("FirstName: \t");
            firstName = ReadLine();

            Write("LastName: \t");
            lastName = ReadLine();
            var newStudent = new Person { Id = id, FirstName = firstName, LastName = lastName };
            await students.Save(newStudent);

            WriteLine("\nSuccessfully added");

            Op = repeat.Repeating();
        break;
        case 2:
            IEnumerable<Person> allStudent = await students.GetAll();

            WriteLine("\nList Students");
            foreach (var student in allStudent)
            {
                WriteLine($"""
                Id:            {student.Id}
                First Name:    {student.FirstName}
                Last Name:     {student.LastName}
            """);
                WriteLine();
            }

            Op = repeat.Repeating();
        break;
        case 3:
            Write("\nEnter the ID of the student you want to edit: ");
            id = int.Parse(ReadLine());

            students.Update(id);

            repeat.Repeating();

            break;
        case 4:
            Write("\nEnter the ID of the student you want to delete: ");
            id = int.Parse(ReadLine());

            students.Delete(id);
            Op = repeat.Repeating();
        break;
        case 5:
        break;
        default:
            WriteLine("La Opcion seleccionada no esta contemplada");
            break;
    }
} while(Op <= 0 || Op > 5);

WriteLine("You left the program");