namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu peso: ");
            double peso = Double.Parse(Console.ReadLine());

            Console.Write("Informe sua altura: ");
            double altura = Double.Parse(Console.ReadLine());

            double IMC = peso / (Math.Pow(altura, 2));

            Console.WriteLine($"IMC: {IMC}");

            if (IMC < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (IMC >= 25 && IMC < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (IMC >= 30)
            {
                Console.WriteLine("Obeso");
            }

        }
    }
}
