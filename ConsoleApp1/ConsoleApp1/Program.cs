using System;

namespace ConsoleApp3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TipoDessaVariavel nomeParaEssaVariavel = atribuirUmValor

            // int - armazenam números inteiros
            int numero1 = 10;

            // float - armazenam números quebrados
            float numero2 = 2.5f;

            // string - armazena um texto
            string nome = "Charles";

            // char - armazena um caractere
            char sexo = 'M';

            Console.WriteLine(numero1);
            Console.WriteLine(sexo);
            Console.WriteLine(nome);
            Console.WriteLine(numero2);


            // bool - verdadeiro ou falso

            // Operadores Aritméticos

            int soma = 5 + 5;
            Console.WriteLine(soma);

            int num1 = 5;
            int num2 = 10;

            int total = (num1 + num2);
            Console.WriteLine(total);

            Console.WriteLine("Escreva um número");
            int numero_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva outro número");
            int numero_3 = Convert.ToInt32(Console.ReadLine());

            int totalN = (numero_2 + numero_3);

            Console.WriteLine("O Total é: " + totalN);



        }
    }
}
