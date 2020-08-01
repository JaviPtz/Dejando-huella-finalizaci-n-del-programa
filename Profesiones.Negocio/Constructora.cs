using Profeciones.Interface;

namespace Profeciones.Negocio
{
    public class Constructora
    {
        //obtengo todas las actividades que realizan los carpintero (métodos)
        public ICarpintero Carpintero { get; set; }


        public string ContratarCarpintero(ICarpintero carpintero) 
        {
            Carpintero = carpintero;
            return "Contrate un carpintero";
        }

        public string Trabajando() {
            return   Carpintero.Medir() + " " + Carpintero.Diseñar() + " " + Carpintero.Clavar() ;
        }

        public string ContratarCarpintero() 
        {
            return $"contraté un carpintero xD";
        }
    }
}
