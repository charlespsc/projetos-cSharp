using System;

namespace ConsoleAppClasses
{
    public class Aluno
    {
        public string nome = "Charles";
        public int nota_tr1 = 10;
        public long cpf = 11122233344;
    }
    internal class Program
    {   
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Aluno aluno1 = new Aluno();

            Console.WriteLine(aluno.nome);

            Aluno tr1 = new Aluno();
            Console.WriteLine(tr1.nota_tr1);
        }
    }
}
