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

            if(TotalContasCriadas == 0)
            {
                TaxaOperacao = 30;

                TotalContasCriadas++;
            } else if(TotalContasCriadas > 0)
            {
                TaxaOperacao = 30 / (TotalContasCriadas + 1);

                TotalContasCriadas++;
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

            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            Console.WriteLine(ContaCorrente.TaxaOperacao);
            Console.ReadLine();
        }
    }
}