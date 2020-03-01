
using ClSemP_OO;
using System;

namespace Exercicio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //sacar dinheiro em um caixa eletronico. ok
            //e escolher entre dois tipo de conta Conta corrente e Conta Poupança ok
            //conta poupança descontar 0.50 ok
            //conta corrente descontar 1.00 ok


            Console.WriteLine("Para Poupança digite '0' ");
            Console.WriteLine("Para conta Corrente digite '1' ");
            Console.Write("Entre com o tipo de Conta: ");            
            var tipoconta = Enum.Parse<TipoConta>(Console.ReadLine());
            Console.Write("Entre com o valor a ser Sacado: ");
            var valor = double.Parse(Console.ReadLine());

            Conta conta =  new ContaCorrente();
            Conta conta1 = new ContaPoupanca();

            double ResultadoSaldo = 0.00;

            if(tipoconta.Equals(TipoConta.contaPoupanca))
            {
                ResultadoSaldo = conta1.Sacar(valor);
            }
            else
            {
                ResultadoSaldo = conta.Sacar(valor);
            }

            Console.WriteLine($"Valor sacado foi de {valor} e o saldo atual é de { ResultadoSaldo }");
            Console.ReadKey();
                       
        }
    }
}
