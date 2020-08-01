using System;
using System.Diagnostics.CodeAnalysis;
using Profeciones.Entidad;
using Profeciones.Interface;

namespace Profeciones.Implementacion
{
    public class CarpinteroMusical : Carpintero, ICarpintero, IEquatable<CarpinteroMusical>
    {

        public string Clavar()
        {
            return "Estoy clavando y escuchando trap";
        }

        public string Diseñar()
        {
            return "Estoy Diseñando y escuchando trap";
        }

        public string Lacando()
        {
            return "Estoy Lacando y escuchando trap";
        }

        public string Lijar()
        {
            return "Estoy Lijando y escuchando trap";
        }

        public string Medir()
        {
            return "Estoy Midiendo y escuchando trap";
        }

        public string Serruchar()
        {
            return "Estoy Serruchando y escuchando trap";
        }

        public bool Equals([AllowNull] CarpinteroMusical other)
        {
            /*comparar la clase actual con la clase que me envia y si las dos tienen el mismo id me manda un true si no un false*/
            return this.Id == other.Id;
        }
    }
}
