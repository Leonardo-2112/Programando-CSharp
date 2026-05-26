using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto;
            double preco;
            Console.WriteLine("Digite o nome do produto: ");
            produto = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine($"O preço do produto {produto} é R$ {preco}");
        }
    }
}
