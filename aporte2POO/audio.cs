using System;
using System.Collections.Generic;
using System.Text;

namespace aporte2POO
{
    public class Audio : Decorador
    {

        public Audio(OrdenB ordenBase) : base(ordenBase)
        {

        }
        public override string software()
        {
            var teclado = "se a agregado el audio adicional";
            return teclado;
        }
    }
}
