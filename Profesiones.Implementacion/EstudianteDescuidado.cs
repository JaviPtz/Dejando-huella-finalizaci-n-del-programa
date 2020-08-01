using Profeciones.Interface;

namespace Profesiones.Implementacion
{
    class EstudianteDescuidado : IEstudiante
    {
        public string Atender()
        {
            return  "En este momento no estoy atendiendo la clase";
        }

        public string Descarsar()
        {
            return "Estoy haciendo otra cosa en clases";
        }

        public string Estudiar()
        {
            return "En la tarde me pongo a estudiar";
        }

        public string HacerDeberes()
        {
            return "En la tarde me pongo hacer los deberes";
        }

        public string IngresarClases()
        {
            return "Estoy pensando en no ingresar a la clase";
        }

        public string Investigar()
        {
            return "En este momento estoy jugando en mi computadora en ves de investigar";
        }

        public string Leer()
        {
            return "Me gusta leer";
        }

        public string Participar()
        {
            return "Hoy no participe nada en la clase";
        }

        public string Preguntar()
        {
            return "Hoy no pregunte nada en la clase";
        }
    }
}
