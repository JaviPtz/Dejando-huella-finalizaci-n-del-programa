
namespace Institucion.Negocio
{
    public class EstudianteAsignatura
    {   //Clase que rompe la relación entre Estudiantes y Asignaturas   
        public int IdEstudiante { get; set; }
        public Estudiante Estudiante { get; set; }
        public int IdAsignatura { get; set; }
        public Asignatura Asignatura { get; set; }
    }
}
