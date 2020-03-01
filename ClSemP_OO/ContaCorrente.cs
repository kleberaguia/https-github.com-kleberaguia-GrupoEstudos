using System;
using System.Collections.Generic;
using System.Text;

namespace ClSemP_OO
{
    public class ContaCorrente : Conta
    {
        public override double Sacar(double valorSacado)
        {
            return Saldo - valorSacado - 1;

        }
    }
}
