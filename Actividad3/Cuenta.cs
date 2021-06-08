using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad3
{
    public class Cuenta
    { 
        private static int Contador {get; set;} = 0;

        public int Cbu {get; set;} = 0;
        
        public double saldo {get; set;} = 0; 
    
       public Cuenta()
       { 
            Contador ++;

            Cbu = Contador;

            saldo = 0;     
       } 

        public void acreditar(double monto) 
        {
            saldo = saldo + monto; 
        }

        public void debitar(double monto)
        {
            saldo = saldo - monto; 
        }

        public bool TieneAlMenos(double monto) => saldo >= monto;

    }  

}