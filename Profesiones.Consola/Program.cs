using System;
using Profeciones.Interface;
using Profeciones.Implementacion;
using Profeciones.Negocio;
using Profeciones.Entidad;

namespace Profesiones.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Constructora MiConstructora = new Constructora();
            MiConstructora.ContratarCarpintero(new CarpinteroEstandar());
            MiConstructora.ContratarCarpintero();
            MiConstructora.Trabajando();

            var carpintero1 = new Carpintero();
            carpintero1.Id = 1;
            carpintero1.Nombre = "Luis";

            var carpintero = new CarpinteroMusical();
            carpintero.Id = 1;
            carpintero.Nombre = "Sebastián";
            MiConstructora.ContratarCarpintero(carpintero);
            MiConstructora.Trabajando();


            Console.WriteLine(MiConstructora.ContratarCarpintero(new CarpinteroEstandar()));
            Console.WriteLine(MiConstructora.Trabajando());
            Console.ReadKey();
        }

    }
}
