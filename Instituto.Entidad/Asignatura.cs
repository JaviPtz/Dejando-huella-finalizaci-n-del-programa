
using System.Collections.Generic;

namespace Institucion.Negocio
{
    public class Asignatura
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IdAsignatura { get; set; }

        public string Nombre { get; set; }

        //modelar una lista de estudiantes con una propiedad

        public List<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();
    }
}
