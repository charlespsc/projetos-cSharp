using System;

namespace ConsoleAppInterface
{
    interface IControle
    {
        void ApertarBotao();
    }

    interface ITela
    {
        void Pintar();
    }

    class ClasseBase : IControle, ITela
    {
        public void ApertarBotao()
        {

        }

        public void Pintar()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }


}