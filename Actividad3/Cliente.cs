using System; 
using System.Collections.Generic;
using System.Text;

namespace  Actividad3
{
    public class Cliente
    {
        public string Nombre {get; set;}

        public string Apellido {get; set;}

        public double Efectivo {get; private set;} = 0;

        public Cuenta Cuenta { get; set; }

        public Estrategia Estrategia {get; set;}

        public Cliente()
        {
           Cuenta = new Cuenta(); 

           Estrategia = IEstrategia;
        }

        public double Saldo => Efectivo + Cuenta.saldo;

        public int Cbu()
        {
            return Cuenta.Cbu ; 
        }

        public void Acreditar(double monto) 
        {
            Efectivo = Efectivo + monto * 0.8;
                                
            Cuenta.acreditar(monto * 0.2);
        } 

        public void Debitar(double monto)
        {
            Efectivo = Efectivo - monto * 0.8;

            Cuenta.debitar(monto * 0.2);
        }

        public bool TieneAlMenos(double monto) => Saldo >= monto;
    }
}