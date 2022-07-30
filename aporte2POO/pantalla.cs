using System;
using System.Collections.Generic;
using System.Text;

namespace aporte2POO
{
    public class Pantalla : Decorador
    {

        public Pantalla(OrdenB ordenBase) : base(ordenBase) { }

        public virtual string reparacion()
        {

            var reparacion = "La pantalla se a reparado correctamente ";
            return reparacion;
        }
    }
}
