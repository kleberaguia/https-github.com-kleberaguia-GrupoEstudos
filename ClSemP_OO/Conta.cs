using System;
using System.Collections.Generic;
using System.Text;

namespace ClSemP_OO
{
    public abstract class Conta
    {
        public int ID { get; set; }
        public TipoConta tipo { get; set; }
        public double Saldo { get; set; } = 1000;

        public abstract double Sacar(double valorSacado);



      
    }
}
