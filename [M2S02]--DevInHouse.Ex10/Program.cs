namespace _M2S02___DevInHouse.Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double numero1, numero2;
            char operacao;

            Console.WriteLine("Olá! Seja bem-vinda(o) a Calculadora!\n");

            do
            {
                Console.WriteLine("Agora, escolha uma operação: \n");

                Console.WriteLine("+ : SOMAR");
                Console.WriteLine("- : SUBTRAIR");
                Console.WriteLine("* : MULTIPLICAR");
                Console.WriteLine("/ : DIVIDIR");
                Console.WriteLine("? : SAIR");

                
                Console.Write("\nDigite a operação escolhida: ");
                operacao = char.Parse(Console.ReadLine());

                if (operacao != '?')
                {
                    Console.Write("Digite o primeiro número: ");
                    numero1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    numero2 = int.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case '+':
                            Console.WriteLine(numero1 + numero2);
                            break;
                        case '-':
                            Console.WriteLine(numero1 - numero2);
                            break;
                        case '*':
                            Console.WriteLine(numero1 * numero2);
                            break;
                        case '/':
                            Console.WriteLine(numero1 / numero2);
                            break;
                        case '?':
                            Console.WriteLine("Saindo do sistema...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }

                }
            } while (operacao != '?');


            Console.WriteLine("\nObrigado por usar a Calculadora!");


             if (operacao == '+')
            {
                Console.WriteLine("soma");
            }
            else if (operacao == '-')
            {
                Console.WriteLine("subtracao");
            }
            else if (operacao == '*')
            {
                Console.WriteLine("multiplicacao");
            }
            else if (operacao == '/')
            {
                Console.WriteLine("divisao");
            }
            else if (operacao == '?')
            {
                Console.WriteLine("sair");
            }
            else
            {
                Console.WriteLine("Opção inválida! Digite uma opção disponível no menu.");
            }

        }
    }
}