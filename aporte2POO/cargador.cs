using System;
using System.Collections.Generic;
using System.Text;

namespace aporte2POO
{
    public class Cargador : Decorador
    {

        public Cargador(OrdenB ordenBase) : base(ordenBase)
        {

        }
        public override string software()
        {
            var teclado = "se a agregado el cargador adicional";
            return teclado;
        }
    }
}
