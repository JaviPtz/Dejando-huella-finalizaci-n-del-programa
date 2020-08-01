using System.Collections.Generic;

namespace Profeciones.Entidad
{
    public class Carpintero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<string> MaterialesParaClavar { get; set; }
    }
}
