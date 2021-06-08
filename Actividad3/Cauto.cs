using System;
using System.Collections.Generic;
using System.Text; 

namespace Actividad3

{
    public class Cauto
    {
        public void Acreditar (Cliente cliente, double monto)
        {
            Efectivo = Efectivo + monto * 0.8; 

            Cuenta.Acreditar(monto * 0.2); 
        }

        public void Debitar (Cliente cliente, double monto)
        {
            Efectivo = Efectivo - monto * 0.8;

            Cuenta.Debitar(monto * 0.2); 
        }

        public bool EsApto (Cliente cliente)
        {

        }
    }
}