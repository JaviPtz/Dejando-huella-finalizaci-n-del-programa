using Institucion.Negocio;

namespace Instituto.Entidad
{   //Clase que rompe la relación entre profesores y asignaturas    
    public class ProfesorAsignatura
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IdProfesor { get; set; }
        public Profesor Profesor { get; set; }

        public int IdAsignatura { get; set; }
        public Asignatura Asignatura { get; set; }



    }
}
