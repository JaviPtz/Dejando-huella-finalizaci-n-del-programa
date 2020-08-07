using Institucion.Negocio;
using Instituto.Entidad;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace Institucion.Consola
{
    class Program
    {
        private const string V = "cohasqui";

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al Instituto!");

            //Instancias de los estudiantes
            Estudiante estudiante = new Estudiante
            {
                Nombre = "Javier",
                Apellido = "Pastaz",
                Nacimiento = new DateTime(2001, 02, 14)
            };

            Estudiante estudiante2 = new Estudiante
            {
                Nombre = "Andy",
                Apellido = "De la cruz",
                Nacimiento = new DateTime(2001, 02, 14)
            };

            //Instancias de las asignaturas

            Asignatura asignatura = new Asignatura
            {
                Nombre = "Programación Visual"
            };

            Asignatura asignatura1 = new Asignatura
            {
                Nombre = "Ingles"
            };

            //Instancias del Curso

            Curso curso1 = new Curso
            {
                Nombre = "cochasqui"
            };

            //Instancias de los Profesores
            Profesor profesor1 = new Profesor
            {
                Nombre = "Roberto",
                Apellido = "Brito",
                Nacimiento = new DateTime(1987, 07, 25)
                 
            };


            //Secretaría
            Secretaria secretaria0 = new Secretaria();
            secretaria0.Matricular(estudiante, asignatura);

            Secretaria secretaria1 = new Secretaria();
            secretaria1.Matricular(estudiante, asignatura1);

            Secretaria secretaria2 = new Secretaria();
            secretaria2.Agregar(estudiante, curso1);

            Secretaria secretaria3 = new Secretaria();
            secretaria3.Agregar(estudiante, curso1);

            //Cordinacion de la carrera
            CoordinacionCarrera coordinacionDesarrollo = new CoordinacionCarrera();
            coordinacionDesarrollo.Asignar(profesor1, asignatura1);
            
            Console.WriteLine($"Hay {Secretaria.Matriculados} estudiantes matriculados");
            Console.WriteLine($"Se han agregado {Secretaria.Agregados} estudiante al curso");
            Console.WriteLine($"A {CoordinacionCarrera.Asignados} profesor se le asignaron {Secretaria.Agregados} materias ");
        }
    }
}
