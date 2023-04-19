namespace _M2S02___DevInHouse.Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a marca do carro: ");
            string marcaCarro = Console.ReadLine();
            Console.WriteLine("Insira o modelo do carro: ");
            string modeloCarro = Console.ReadLine();
            Console.WriteLine("Insira o km rodado");
            double kmCarro = Convert.ToInt32(Console.ReadLine());   

            if(kmCarro > 9999 ) 
            {
                Console.WriteLine($"Seu carro da {marcaCarro} do modelo {modeloCarro} ja passou dos km de revisão {kmCarro}");
            }
            else
            {
                Console.WriteLine($"Seu carro da {marcaCarro} da {modeloCarro} ainda ta no km aceitavel {kmCarro}");
            }
        }
    }
}