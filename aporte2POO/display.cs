using System;
using System.Collections.Generic;
using System.Text;

namespace aporte2POO
{
    public class display : Decorador
    {

        public display(OrdenB ordenBase) : base(ordenBase)
        {

        }

        public virtual string reparar()
        {

            var reparacion = "la reparacion del display del telefono celular se a completado ";

            return reparacion;
        }
    }
}
