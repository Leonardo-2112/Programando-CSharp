using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine(numero % 2 == 0 ? "Par" : "Ímpar");
            Console.WriteLine(numero == 10 ? "Igual a dez" : "Diferente de dez");

        }
    }
}
