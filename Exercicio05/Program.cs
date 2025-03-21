namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salário atual: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a quantidade de vendas que você obteve: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o percentual da comissão % :");
            double percentualComissao = Convert.ToDouble(Console.ReadLine());

            double comissao = (percentualComissao / 100) * totalVendas;

            double salarioTotal = salarioBase + comissao;

            Console.WriteLine($"Sua comissão é de: {comissao:F2}");
            Console.WriteLine($"Seu salário total é de: {salarioTotal:F2}");

        }
    }
}
