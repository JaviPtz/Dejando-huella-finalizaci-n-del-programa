﻿using System;

namespace Instituto.Entidad
{
    public class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }

        //solo mis desendientes pueden usarlo proteced
        protected void Leer()
        {
            //to do
        }
    }
}
