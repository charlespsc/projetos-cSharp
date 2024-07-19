using System;

namespace ConsoleAppMetodos
{
    abstract class Motocicleta
    {
        // Qualquer um consegue chamar este methodo 
        public void LigarMoto() { }

        // Somente classes derivadas conseguem chamar (heranças)
        protected void AdicionarGasolina(int galoes) { }

        public abstract double ChegarNaVelocidadeX();

        public virtual int Drive(int quilometros, int velocidade) { }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}