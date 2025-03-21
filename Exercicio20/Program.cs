namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
