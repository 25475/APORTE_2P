using System;
using System.Collections.Generic;
using System.Text;

namespace aporte2POO
{
    public class Dispositivo1 : OrdenB
    {
        public override string reparacion()
        {
            var rep = "El primer dispositivo  está en reparación";
            return rep;
        }
        public override string software()
        {
            var rep = "Agregando hardware adicional al primer dispositivo ";
            return rep;
        }
    }
}
