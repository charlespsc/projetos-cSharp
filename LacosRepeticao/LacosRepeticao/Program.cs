class Program
{
    static void Main(string[] args)
    {
        // Estrutura de Repetição

        // While -> Pode não executar
        int numero = 0;

        while (numero <= 10)
        {
            Console.WriteLine(numero);
            numero++;
        }

        // For
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Do (while) -> Executa 1 ou mais vezes
        int numero1 = 0;

        do
        {
            Console.WriteLine(numero1);
            numero1++;
        } while (numero1 <= 10);

    }

}