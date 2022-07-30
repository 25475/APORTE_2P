using System;
using System.Collections.Generic;
using System.Text;

namespace aporte2POO
{
    public class Dispositivo2 : OrdenB
    {
        public override string reparacion()
        {
            var rep = "El dispositivo 2 está en reparación";
            return rep;
        }
        public override string software()
        {
            var rep = "Agregando hardware adicional al segundo dispositivo";
            return rep;
        }
    }
}
