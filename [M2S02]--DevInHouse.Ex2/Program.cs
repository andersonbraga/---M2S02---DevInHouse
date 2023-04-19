namespace _M2S02___DevInHouse.Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0) 
            {
                Console.WriteLine($"Numero par {numero}");
            }
            else
            {
                Console.WriteLine($"Numero impar {numero}");
            }
        }
    }
}