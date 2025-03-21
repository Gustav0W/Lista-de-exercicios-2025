namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            byte idade = byte.Parse(Console.ReadLine());

            int diasVividos = idade * 365;

            Console.WriteLine($"{nome}! Você viveu {diasVividos} dias");
        }
    }
}
