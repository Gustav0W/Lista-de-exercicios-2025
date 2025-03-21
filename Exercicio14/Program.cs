namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[3];

            for (int i = 0; i <= 2; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(valores);
            Array.Reverse(valores);

            Console.WriteLine($"Valores em ordem decrescente: {string.Join(", ", valores)}");

            
        }
    }
}
