namespace _M2S02___DevInHouse.Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int maior = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            Console.WriteLine($"O maior número digitado foi {maior}.");
        }
    }
}