namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas broas você vendeu: ");
            int quantBroas = int.Parse(Console.ReadLine());

            Console.Write("Quantos pães você vendeu: ");
            int quantPaes = int.Parse(Console.ReadLine());

            double paes = 0.12;
            double broas = 1.50;

            double receita = (quantBroas * broas) + (quantPaes * paes);

            double guardarPoupanca = receita * 0.1;

            Console.WriteLine($"Você vendeu {quantPaes} pães");
            Console.WriteLine($"Você vendeu {quantBroas} broas");
            Console.WriteLine($"Sua receita foi de R${receita}");
            Console.WriteLine($"Você deve guardar R${guardarPoupanca:F2}");
        }
    }
}
