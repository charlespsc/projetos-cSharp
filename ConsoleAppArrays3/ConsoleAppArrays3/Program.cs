using System;

namespace ConsoleAppArrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 estudantes
            // Idade dos estudantes
            // Exibir o estudante mais velho e o mais novo

            String[] estudantes = new String[10];
            int[] idade = new int[10];
            String[] lista = new String[10];

            Console.WriteLine("Digite o nome de 10 estudantes e sua respectiva idade");

            for(int p = 0; p < estudantes.Length; p++)
            {
                Console.WriteLine("Nome do estudante:");
                estudantes[p] = Console.ReadLine();

                Console.WriteLine("Idade do estudante:");
                idade[p] = Convert.ToInt16(Console.ReadLine());

                if (idade[p] < 10)
                {
                    lista[p] = "0" + idade[p] + " " + estudantes[p];
                } else
                {
                    lista[p] = idade[p] + " " + estudantes[p];
                }
            }

            Array.Sort(lista);
            foreach (String p in lista) 
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("O estudante mais velho é o " + lista[10]);
            Console.WriteLine("O estudante mais novo é o " + lista[0]);
        }
    }
}
