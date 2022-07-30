using System;
using System.Collections.Generic;
using System.Text;

namespace aporte2POO
{
    public class Parlante : Decorador
    {

        public Parlante(OrdenB ordenBase) : base(ordenBase) { }

        public override string software()
        {
            var teclado = "el parlante adicional se a agregado correctamente";
            return teclado;
        }
    }
}
