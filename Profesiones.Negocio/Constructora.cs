using Profeciones.Interface;

namespace Profeciones.Negocio
{
    public class Constructora
    {
        public ICarpintero Carpintero { get; set; }

        public string ContratarCarpintero(ICarpintero carpintero) 
        {
            Carpintero = carpintero;
            return "Contrate un carpintero";
        }

        public string ConstruirMesa() {
            return Carpintero.Diseñar() + "Mesa" +
                   Carpintero.Medir() + "Mesa" +
                   Carpintero.Clavar() + "Mesa";
        }

        public string ContratarCarpintero() 
        {
            return "contraté un carpintero";
        }
    }
}
