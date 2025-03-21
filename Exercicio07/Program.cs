namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peso1 = 2;
            int peso2 = 3;

            Console.Write("Informe o valor da prova 1: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor da prova 2: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            double media = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

            Console.WriteLine($"A média ponderada é {media}");
        }
    }
}
