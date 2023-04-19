namespace _M2S02___DevInHouse.Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Digite um número inteiro positivo: ");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("o número deve ser positivo e diferente de zero. Tente novamente.");
                }

            } while (numero <= 0);


            for (int i = 0; i < numero; i += 2)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}