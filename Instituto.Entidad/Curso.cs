using Institucion.Negocio;
using System.Collections.Generic;

namespace Instituto.Entidad
{
    public class Curso
    {
        public int IdCurso{ get; set; }

        public string Nombre { get; set; }

        public Estudiante Estudiante { get; set; }

        public List<Curso> Cursos { get; set; } = new List<Curso>();

    }
}
