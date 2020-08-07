using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Instituto.Entidad
{
    public class Profesor : Persona
    {
        [Key]
        public int IdProfesor { get; set; }

        // una lista de Asignaturas
        public List<ProfesorAsignatura> ProfesorAsignaturas { get; set; } = new List<ProfesorAsignatura>();
    }
}
