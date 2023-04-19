namespace _M2S02___DevInHouse.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero1 para somar: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o numero2 para somar: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
    }
}