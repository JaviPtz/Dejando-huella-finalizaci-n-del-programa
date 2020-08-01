using Profeciones.Interface;

namespace Profesiones.Implementacion
{
    class EstudianteAplicado : IEstudiante
    {
        public string IngresarClases()
        {
            return "Voy a ingresar a mi clase de matemática";
        }
        public string Atender()
        {
            return "Estoy atendiendo en mi primera clase";
        }

        public string Estudiar()
        {
            return "Estoy estudiando matemáticas";
        }

        public string HacerDeberes()
        {
            return "Estoy haciendo los deberes de matemáticas";
        }

        public string Investigar()
        {
            return "Estoy investigando un tema de la clase que no me quedo claro";
        }

        public string Leer()
        {
            return "Estoy leyendo la isla misteriosa de Julio Verne";
        }

        public string Participar()
        {
            return "En mi clases de matemáticas participe mucho";
        }

        public string Preguntar()
        {
            return "Una pregunta profe puede repetir esta parte";
        }

        public string Descarsar()
        {
            return "Voy a descansar un poco y después continuo estudiando";
        }
    }
}
