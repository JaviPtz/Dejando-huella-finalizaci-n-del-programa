using System.Collections.Generic;
using Profeciones.Interface;
using Profeciones.Entidad;
/*conposición*/
namespace Profeciones.Implementacion
{
    public class CarpinteroModerno : ICarpintero
    {

        private Carpintero carpintero = new Carpintero();

        public int Id { get { return carpintero.Id; } set { carpintero.Id = value; } }
        public string Diseñar()
        {
            return "Estoy diseñando con Autocard";
        }
        public string Serruchar()
        {
            return "Estoy serruchando con máquina";
        }
        public string Medir()
        {
            return "Estoy midiendo con laser";
        }
        public string Clavar()
        {
            return "Estoy clavando con pistola de aire comprimidp";
        }
        public string Lijar()
        {
            return "Estoy lijando con lijadora con absorción";
        }

        public string Lacando()
        {
            return "Estoy lacando con laca de secado instantaneo";
        }

    }
}
