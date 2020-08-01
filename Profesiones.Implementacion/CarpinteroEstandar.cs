using System;
using Profeciones.Interface;

namespace Profeciones.Implementacion
{
    public class CarpinteroEstandar : ICarpintero
    {
        public string Diseñar()
        {
            return "Estoy diseñando";
        }
        public string Serruchar()
        {
            return "Estoy serruchando";
        }
        public string Medir()
        {
            return "Estoy midiendo";
        }
        public string Clavar()
        {
            return "Estoy clavando";
        }
        public string Lijar()
        {
            return "Estoy lijando";
        }

        public string Lacando()
        {
            return "Estoy lacando";
        }

    }
}
