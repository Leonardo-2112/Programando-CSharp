using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, novoSalario;
            Console.WriteLine("Digite o nome do funcionário: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salário: ");
            salario = double.Parse(Console.ReadLine());
            novoSalario = salario + (salario * 0.15);
            Console.WriteLine($"Funcionário: {nome}\nSalário Antigo: R$ {salario:F2}\nSalário Com Aumento de 15%: R$ {novoSalario:F2}");
        }
    }
}
