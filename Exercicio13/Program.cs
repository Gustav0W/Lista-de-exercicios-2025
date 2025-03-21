namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor C: ");
            int C = int.Parse(Console.ReadLine());

            if (A + B > C)
                Console.Write($"A soma de A({A}) + B({B}) é maior que C({C}): ");
            else if (A + B == C)
                Console.Write($"A soma de A{A} + B{B} é igual à C({C})");
            else 
                Console.Write($"A soma de A{A} + B{B} é menor que C({C})");
        }
    }
}
