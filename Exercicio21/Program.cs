using System.Threading.Tasks.Dataflow;

namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor: ");
            int valor = int.Parse(Console.ReadLine());

            int fatorial = 1;

            Console.Write($"{valor}! = {valor}");
            for (int i = valor; i > 0; i--)
            {
                fatorial *= i;
                if (i < valor) 
                Console.Write($"x{i}");
            }
            Console.Write($" = {fatorial}");
            Console.WriteLine($"\nResultado fatorial: {fatorial}");
        }
    }
}
