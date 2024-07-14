using System;

namespace PrimeiroApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1º Jogo de Perguntas
            // 2º Console.WriteLine -> imprimir as perguntas na tela
            // 3º Recolher os dados 
            // 4º Atribuir esses dados a algumas variáveis

            int pontuacao = 0;

            // Pergunta 1
            Console.WriteLine("Quanto é 5 + 5?\nEscreva sua resposta abaixo:");
            int resposta_1 = Convert.ToInt32(Console.ReadLine());

            if (resposta_1 == 10)
            {
                pontuacao++;
            }
            Console.WriteLine("O seu total de pontos foi: " + pontuacao);

            // Pergunta 2
            Console.WriteLine("Quanto é 10 + 5?\nEscreva sua resposta abaixo:");
            int resposta_2 = Convert.ToInt32(Console.ReadLine());

            if (resposta_2 == 15)
            {
                pontuacao++;
            }
            Console.WriteLine("O seu total de pontos foi: " + pontuacao);

            // Pergunta 3
            Console.WriteLine("Quem é o CEO da Tesla?\nEscreva sua resposta abaixo:");
            string resposta_3 = Console.ReadLine();

            if (resposta_3 == "Elon")
            {
                pontuacao++;
            }
            Console.WriteLine("O seu total de pontos foi: " + pontuacao);

            // Pergunta 4
            Console.WriteLine("Quem é o Instrutor do Senai?\nEscreva sua resposta abaixo:");
            string resposta_4 = Console.ReadLine();

            if (resposta_4 == "Charles")
            {
                pontuacao++;
            }
            Console.WriteLine("O seu total de pontos foi: " + pontuacao);

            // Pergunta 5
            Console.WriteLine("Quanto é 12,5 + 2?\nEscreva sua resposta abaixo:");
            float resposta_5 = float.Parse(Console.ReadLine());

            if (resposta_5 == 14.5f)
            {
                pontuacao++;
            }

            // 5º Mostrar uma pontuação para o usuário
            Console.WriteLine("O seu total de pontos foi: " + pontuacao);

        }
    }
}