using Instituto.Entidad;
using System.Collections.Generic;

namespace Institucion.Negocio
{
    public class Estudiante : Persona
    {
        public int IdEstudiante { get; set; }

        public List<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();

        public List<ProfesorAsignatura> ProfesorAsignaturas{ get; set; } = new List<ProfesorAsignatura>();
        public void Estudiar()
        {
            base.Leer();
        }
    }
}
