using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            if (num == 10)
            {
                Console.WriteLine("Igual a 10");
            }
            else if (num == 20)
            {
                Console.WriteLine("Igual a 20");
            }
            else if (num == 30)
            {
                Console.WriteLine("Igual a 30");
            }
            else
            {
                Console.WriteLine("Diferente de 10, 20, 30");
            }
        }
    }
}
