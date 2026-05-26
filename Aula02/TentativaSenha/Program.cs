using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentativaSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Senha correta do sistema
            string senhaCorreta = "1234";

            //Variável para armazenar a senha digitada
            string senhaDigitada = "";

            //Repete enquanto a senha estiver incorreta
            while (senhaDigitada != senhaCorreta)
            {
                Console.WriteLine("Digite a senha: ");
                senhaDigitada = Console.ReadLine();

                if(senhaDigitada == senhaCorreta)
                {
                    Console.WriteLine("Acesso permitido!");
                }
                else
                {
                    Console.WriteLine("Senha Incorreta. Tente Novamente.\n");
                }
            }

        }
    }
}
