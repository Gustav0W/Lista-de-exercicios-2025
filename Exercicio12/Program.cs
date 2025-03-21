namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanto você recebe ?: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            decimal salarioAumentado = salario * 1.15m;
            decimal salarioReduzido = salarioAumentado * 0.08m;

            salarioReduzido = salarioAumentado - salarioReduzido;

            Console.WriteLine($"O novo salário seria R${salarioAumentado}, mas com o desconto de impostos fica R${salarioReduzido}");
        }
    }
}
