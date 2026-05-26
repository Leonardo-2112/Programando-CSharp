using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double n1;
            double n2;
            do
            {
                Console.WriteLine("============Calculadora=============");
                Console.WriteLine("1-Soma");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("3-Multiplicação");
                Console.WriteLine("4-Divisão");
                Console.WriteLine("0-Sair");
                Console.WriteLine("====================================");
                Console.WriteLine("Escolha uma Opção: ");
                opcao = int.Parse(Console.ReadLine());
                if(opcao == 0)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                Console.WriteLine("Digite o primeiro número: ");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                n2 = double.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"O resultado de {n1} + {n2} é {n1+n2}");
                        break;
                    case 2:
                        Console.WriteLine($"O resultado de {n1} - {n2} é {n1 - n2}");
                        break;
                    case 3:
                        Console.WriteLine($"O resultado de {n1} X {n2} é {n1 * n2}");
                        break;
                    case 4:
                        Console.WriteLine($"O resultado de {n1} / {n2} é {n1 / n2}");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
