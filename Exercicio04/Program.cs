namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a temperatura em Celsius: ");
            double tempCelsius = Convert.ToDouble(Console.ReadLine());

            double convertido = (tempCelsius * 9/5) + 32;

            Console.WriteLine($"Valor convertido: {convertido}Fº");
            Console.ReadLine();

        }
    }
}
