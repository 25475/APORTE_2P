using System;
using System.Collections.Generic;
using System.Text;

namespace aporte2POO
{
    public class Formatear : Decorador
    {

        public Formatear(OrdenB ordenBase) : base(ordenBase) { }
        public virtual string reparacion()
        {
            var reparacion = "El celular se a formateado correctamente ";
            return reparacion;
        }
    }
}
