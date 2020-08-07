using Instituto.Entidad;

namespace Institucion.Negocio
{
    public class CoordinacionCarrera
    {
        public static int Asignados { get; set; }

        public void Asignar(Profesor profesor, Asignatura asignatura)
        {
            profesor.ProfesorAsignaturas.Add(new ProfesorAsignatura
            {
                Asignatura = asignatura,
                Profesor = profesor,
            });
            Asignados++;
        }

    }
}
