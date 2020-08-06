using Instituto.Entidad;
using System.Collections.Generic;

namespace Institucion.Negocio
{
    public class Estudiante: Persona
    {
        public int EstudianteId { get; set; }

        //public Curso Curso { get; set; }
        public List<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();
        //public List<Estudiante> Estudiantes{ get; set; } = new List<Estudiante>();

        public void Estudiar()
        {
            base.Leer();
        }
    }
}
