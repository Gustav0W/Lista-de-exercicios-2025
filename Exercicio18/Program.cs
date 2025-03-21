namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i}.. ");
                }
            }
        }
    }
}
