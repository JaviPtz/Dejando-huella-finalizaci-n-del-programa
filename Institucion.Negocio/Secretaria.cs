using Instituto.Entidad;

namespace Institucion.Negocio
{
    public class Secretaria
    {
        public static int Matriculados { get; set; }
        public static int Agregados { get; set; }

        public void Matricular(Estudiante estudiante, Asignatura asignatura)
        {
            estudiante.EstudianteAsignaturas.Add(new EstudianteAsignatura
            {
                Asignatura = asignatura,
                Estudiante = estudiante,
            });
            Matriculados++;
        }

        //pendiente
        /*public void Agregar(Estudiante estudiante, Curso curso)
        {
            estudiante.Estudiantes.Add(new Estudiante
            {
                Curso = curso
            });
            Agregados++;
        }*/
        public void Agregar(Estudiante estudiante, Curso curso)
        {
            curso.Cursos.Add(new Curso
            {
                   Estudiante = estudiante
            });
            Agregados++;
        }

    }
}
