using System;
using System.Collections.Generic;
using System.Text;
using Profeciones.Interface;

namespace Profeciones.Implementacion
{
    class CarpinteroAntiguo : ICarpintero
    {
        private List<string> materialesParaClavar;
        private string nombre;

        public string Nombre { get { return nombre; }  set { nombre = value; } }
        public List<string> MaterialesParaClavar{ get { return materialesParaClavar; } set{ materialesParaClavar = value; } }
        public string Saludar()
        {
            return $"mi nombre es {nombre} y estoy clavando {materialesParaClavar[0]}";
        }

        public string Serruchar()
        {
            throw new NotImplementedException();
        }

        public string Clavar()
        {
            return "Estoy clavando a la antigua";
        }

        public string Diseñar()
        {
            return "Estoy Diseñando a la antigua";
        }

        public string Lacando()
        {
            return "Estoy lacando a la antigua";

        }

        public string Lijar()
        {
            return "Estoy lijando a la antigua";
        }

        public string Medir()
        {
            return "Estoy Midiendo a la antigua";
        }
    }
}
