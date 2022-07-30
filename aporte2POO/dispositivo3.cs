using System;
using System.Collections.Generic;
using System.Text;

namespace aporte2POO
{
    public class Dispositivo3 : OrdenB
    {
        public override string reparacion()
        {
            var rep = "El dispositivo 3 está en reparación";
            return rep;
        }
        public override string software()
        {
            var rep = "Agregando hardware adicional al tercer dispositivo ";
            return rep;
        }
    }
}
