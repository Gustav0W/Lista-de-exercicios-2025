namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor A: ");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor B: ");
            int valorB = int.Parse(Console.ReadLine());

            int valorC = 0;

            if (valorA == valorB)
            {
                valorC = valorA + valorB;
                Console.WriteLine($"Os valores foram somados e resultaram em: {valorC}");
            }
            else
            {
                valorC = valorA * valorB;
                Console.WriteLine($"Os valores foram multiplicados e resultaram em: {valorC}");
            }

            

        }
    }
}
