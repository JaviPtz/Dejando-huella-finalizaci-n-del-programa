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

        public string ConstruirMesa() {
            return   Carpintero.Medir() + "Mesa" + " " + Carpintero.Diseñar() + "Mesa" + " " + Carpintero.Clavar() + "Mesa";
        }

        public string ContratarCarpintero() 
        {
            return "contraté un carpintero";
        }
    }
}
