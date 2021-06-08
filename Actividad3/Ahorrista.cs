using System;
using System.Collections.Generic;
using System.Text; 

namespace Actividad3

{
    public class Ahorrista
    {
        public void Acreditar (Cliente cliente, double monto)
        {
            Efectivo = Efectivo + monto * 0.5; 

            Cuenta.Acreditar(monto * 0.5);
        }

        public void Debitar (Cliente cliente, double monto)
        {
            Efectivo = Efectivo - monto;

            Cuenta.Debitar(monto);
        }

        public bool EsApto (Cliente cliente)
        {
            
        }
    }
}