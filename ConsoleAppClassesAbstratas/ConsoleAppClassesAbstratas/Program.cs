using System;

namespace ConsoleAppClassesAbstratas
{
    abstract class Forma
    {
        public abstract int CalcularArea();
    }

    class Quadrado : Forma
    {
        int lado;
        public Quadrado(int n) => lado = n;

        public override int CalcularArea() => lado * lado;
    }
       
    class Program
    {       
        static void Main(string[] args)
        {
            var qd = new Quadrado(12);

            Console.WriteLine($"Área do quadrando = {qd.CalcularArea()}");
        }
    }
}