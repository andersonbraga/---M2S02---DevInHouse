namespace _M2S02___DevInHouse.Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome paciente: ");
            string nomePaciente = Console.ReadLine();
            Console.WriteLine("Digite sua idade paciente: ");
            int idade = Convert.ToInt32(Console.ReadLine());    

            if (idade > 17 ) 
            {
                Console.WriteLine($"Paciente {nomePaciente} é  maior de idade {idade}");
            }
            else
            {
                Console.WriteLine($"Paciente {nomePaciente} é menor de idade {idade}");
            }
        }
    }
}