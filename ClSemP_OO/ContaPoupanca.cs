using System;
using System.Collections.Generic;
using System.Text;

namespace ClSemP_OO
{
    public class ContaPoupanca : Conta
    {

        public override double Sacar(double valorSacado)
        {
            return Saldo - valorSacado - 0.50;
        }
    }
}
