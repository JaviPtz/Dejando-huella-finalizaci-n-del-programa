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
            MiConstructora.ConstruirMesa();

            var carpintero1 = new Carpintero();
            carpintero1.Id = 1;
            MiConstructora.ContratarCarpintero(new CarpinteroModerno());
            MiConstructora.ConstruirMesa();

            var carpintero = new CarpinteroMusical();
            carpintero.Id = 1;
            MiConstructora.ContratarCarpintero(carpintero);

            Console.WriteLine(MiConstructora.ContratarCarpintero());
            Console.WriteLine(MiConstructora.ConstruirMesa());
            Console.ReadKey();
        }

    }
}
