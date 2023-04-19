namespace _M2S02___DevInHouse.Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int[] numeros = new int[4];

            for (int i = 0; i < numeros.Length; i++) 
            {
                Console.WriteLine("Digite 4 numeros: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            
            Array.Sort(numeros);
            Array.Reverse(numeros);

            for (int i = 0;i < numeros.Length;i++)
            {
                Console.WriteLine(numeros[i]);
            }
            
        }
    }
}