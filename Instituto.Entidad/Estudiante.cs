using Instituto.Entidad;
using System.Collections.Generic;

namespace Institucion.Negocio
{
    public class Estudiante: Persona
    {
        public int EstudianteId { get; set; }

        public List<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();

        public void Estudiar()
        {
            base.Leer();
        }
    }
}
