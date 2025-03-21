namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double kmInicial = 0;
            double kmFinal = 0;

            double consumoCombustivel = 0;

            double distanciaPercorrida = kmFinal - kmInicial;

            double consumoPorKm = distanciaPercorrida / consumoCombustivel;

            Console.WriteLine($"O consumo de combustível no trajeto  ~ {consumoPorKm} km/L");

            Console.ReadLine();
        }
    }
}
