namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine()!);
            
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write($"1º: {a}\n2º: {b}\n");

            for (int i = 3; i <= numero; i++)
            {

                c = a + b;
                a = b;
                b = c;

                Console.WriteLine($"{i}º: {c}");
            }

        }
    }
}
