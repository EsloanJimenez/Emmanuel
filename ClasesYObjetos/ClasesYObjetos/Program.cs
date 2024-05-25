/*
    1. Clases y Objetos :
    - Ejercicio : Crea una clase Persona que tenga atributos nombre, edad y dirección.
    Incluye un método para mostrar la información de la persona en consola.

    Objetivo : Comprender la creación de clases y objetos.

    2. Métodos :
    Ejercicio : Extiende la clase Persona para incluir un método que calcule el año de nacimiento de la persona basado en su edad.
    Objetivo : Aprender a definir y utilizar métodos dentro de una clase.

    3. Herencia :
    Ejercicio : Crea una clase Empleado que herede de la clase Persona e incluya atributos adicionales como puesto y salario. Implementa un método para mostrar toda la información del empleado en consola.
    Objetivo : Aprender sobre herencia y cómo extender clases existentes.

    4. Polimorfismo :
    Ejercicio : Crea una clase Animal con un método hacerSonido(). Luego, crea clases derivadas como Perro y Gato que sobreescriban el método hacerSonido() para proporcionar implementaciones específicas.
    Objetivo : Comprender el polimorfismo y la capacidad de las clases derivadas para modificar comportamientos.
*/

using ClasesYObjetos.Clases;

Persona persona = new Persona("Enrique", 30, "Sagrario Diaz");

persona.mostrarInfo();

Console.Write("\nCuantos años tienes: ");
int edad = int.Parse(Console.ReadLine());

CalcularEdad calcularEdad = new CalcularEdad(edad);

Console.WriteLine(calcularEdad.añoNacimiento());