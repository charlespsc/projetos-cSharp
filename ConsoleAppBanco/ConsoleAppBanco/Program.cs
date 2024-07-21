using System;

namespace ConsoleAppBanco
{
    public class ContaCorrente
    {
        private int Agencia;
        private int Numero;

        public static double TaxaOperacao { get; private set; }
        public static int TotalContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            try
            {
                TotalContasCriadas++;
                TaxaOperacao = 30 / TotalContasCriadas;
                Console.WriteLine("O resultado é " + TaxaOperacao);
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Não podemos dividir por ZERO!");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {   
            ContaCorrente conta = new ContaCorrente(9999, 123456);
            ContaCorrente conta2 = new ContaCorrente(8888, 654321);
            ContaCorrente conta3 = new ContaCorrente(7777, 123321);
        }
    }
}