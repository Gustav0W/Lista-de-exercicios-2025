namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a base do terreno: ");
            double baseTerreno = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a altura do terreno: ");
            double alturaTerreno = Convert.ToDouble(Console.ReadLine());

            double areaTerreno = baseTerreno * alturaTerreno;

            Console.WriteLine($"A área do terreno é {areaTerreno}m³");
        }
    }
}
