using System;

namespace ConsoleAppArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes;
            nomes = new string[5];

            nomes[0] = "Joana";
            nomes[1] = "Roberto";
            nomes[2] = "João";
            nomes[3] = "Natália";
            nomes[4] = "Ana";

            foreach (string nome in nomes) 
            { 
                Console.WriteLine(nome);
            }
        }
    }
}
