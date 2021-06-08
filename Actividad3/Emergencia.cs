using System;
using System.Collections.Generic;
using System.Text; 

namespace Actividad3

{
    public class Emergencia 
    {
        public void Debitar (Cliente cliente, double monto)
        {
            
        }

        public void Acreditar (Cliente cliente, double monto)
        {
            Efectivo = Efectivo + monto;
        }

        public bool EsApto (Cliente cliente)
        {
            
        }
    }
}