namespace _M2S02___DevInHouse.Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números deseja calcular a média: ");
            int quantidade = int.Parse(Console.ReadLine());

            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int soma = 0;

            foreach (int numero in numeros)
            {
                soma += numero;
            }

            double media = (double)soma / quantidade;

            Console.WriteLine($"A média dos números é: {media}");
        }
    }
}