using System;

namespace ConsoleAppConstrutor
{
    public class Aluno
    {
        public Aluno(string nome)
        {
            nomeDoAluno = nome;
        }
        public string nomeDoAluno { get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Charles");
            Console.WriteLine(aluno1.nomeDoAluno);

            Aluno aluno2 = new Aluno("Luan");
            Console.WriteLine(aluno2.nomeDoAluno);

        }
    }
}

