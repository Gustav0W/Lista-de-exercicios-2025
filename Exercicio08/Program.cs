namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool primo = true;

            if (numero % 2 == 0 && numero != 2) 
            {
                primo = false;
            }

            for (int i = 3; i < numero; i += 2)
            {
                if (numero % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            if (primo)
            {
                Console.WriteLine("O número é primo.");
            }
            else
            {
                Console.WriteLine("O número não é primo.");
            }
        }
    }
}
