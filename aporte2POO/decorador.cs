using System;
using System.Collections.Generic;
using System.Text;

namespace aporte2POO
{
    public class Decorador
    {
        protected OrdenB orden;

        public Decorador(OrdenB orden)
        {
            this.orden = orden;
        }
        public virtual string software()
        {
            return orden.software();
        }
        public virtual string reparacion()
        {
            return orden.reparacion();
        }
    }
}
