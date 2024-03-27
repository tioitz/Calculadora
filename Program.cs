using System.Security.Cryptography.X509Certificates;

namespace Calculadora.Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Qual operação deseja fazer?");
                Console.WriteLine("1- Adição");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação");
                Console.WriteLine("4- Divisão");
                Console.WriteLine("5- Sair");

                Console.WriteLine("Opção: ");
                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 5)
                {
                    break;
                }

                if (operacao > 5 || operacao < 1) // "||" significa "ou", no caso se a opcao foi maior que 5 OU menor que 1, será uma opcao inválida
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }


                Console.WriteLine("Digite o primeiro número:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (operacao)
                {
                    case 1:
                        {
                            resultado = num1 + num2;
                            break;
                        }
                    case 2:
                        {
                            resultado = num1 - num2;
                            break;
                        }
                    case 3:
                        {
                            resultado = num1 * num2;
                            break;
                        }
                    case 4:
                        {
                            if (num2 != 0)
                                resultado = num1 / num2;
                            else

                                Console.WriteLine("Não é possivél dividir por zero!");
                            break;
                        }
                    case 5:
                        continuar = false;
                        break;
                }


                Console.WriteLine("O resultado da operação é: {0}", resultado);
            }
            Console.WriteLine("Obrigado por usar a calculadora!");

        }
    }
}
// double e decimal são "irmãos". Use os dois no lugar de int para fazer operações com numeros quebrados