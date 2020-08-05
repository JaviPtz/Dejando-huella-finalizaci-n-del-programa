using Institucion.Negocio;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace Institucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al Instituto!");
            Estudiante estudiante = new Estudiante
            {
                Nombre = "Javier",
                Apellido = "Pastaz",
                Nacimiento = new DateTime(2001, 02, 14)
            };

            Asignatura asignatura = new Asignatura
            {
                Nombre = "Programación Visual"
            };

            Asignatura asignatura1 = new Asignatura
            {
                Nombre = "Ingles"
            };

            Secretaria secretaria0 = new Secretaria();
            secretaria0.Matricular(estudiante, asignatura);

            Secretaria secretaria1 = new Secretaria();
            secretaria1.Matricular(estudiante, asignatura1);

            Console.WriteLine($"Hay {Secretaria.Matriculados} estudiantes matriculados");
        }
    }
}
