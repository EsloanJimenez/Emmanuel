using ListaEstudiantes.Class;
using ListaEstudiantes.Entity;
using ListaEstudiantes.Excep;
using static System.Console;

var students = new Course<Person>();

WriteLine("Welcom to list students \n");

int id, Op = 0;
string firstName, lastName;

do
{
    try
    {
        Menu.Option();
        Op = int.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
        WriteLine("Select a numerical data type\n");
    }
    
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

            students.Save(newStudent);

            Op = Repeat.Repeating();
        break;
        case 2:
            IEnumerable<Person> allStudent = students.GetAll();

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

            Op = Repeat.Repeating();
        break;
        case 3:
            Write("\nEnter the ID of the student you want to edit: ");
            id = int.Parse(ReadLine());

            students.Update(id);

            Op = Repeat.Repeating();

            break;
        case 4:
            Write("\nEnter the ID of the student you want to delete: ");
            id = int.Parse(ReadLine());

            students.Delete(id);
            Op = Repeat.Repeating();
        break;
        case 5:
        break;
        default:
            WriteLine("The selected Option is not contemplated\n");
            break;
    }
} while(Op <= 0 || Op > 5);

WriteLine("See you later");