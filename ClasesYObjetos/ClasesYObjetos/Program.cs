﻿/*
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

Console.Write("Cual es su nombre: \t");
string nombre = Console.ReadLine();

Console.Write("\nCuantos años tienes: \t");
int edad = int.Parse(Console.ReadLine());

Console.Write("\nCual es su direccion: \t");
string direccion = Console.ReadLine();

Persona persona = new Persona(nombre, edad, direccion);

persona.mostrarInfo();
Console.WriteLine($"Año nacimiento: {persona.añoNacimiento()}");

