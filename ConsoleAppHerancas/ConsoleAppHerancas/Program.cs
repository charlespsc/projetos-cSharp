using System;

namespace ConsoleAppHerancas
{
    public class Alessandra
    {
        private int valor = 10;

        public class Bruno : Alessandra
        {
            public int PegarValor()
            {
            return this.valor;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Bruno = new Alessandra.Bruno();
            Console.WriteLine(Bruno.PegarValor());
        }
    }
}