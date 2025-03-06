using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise07
    {
        public static void Run()
        {
            Console.Write("Digite um número inteiro: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
            }
        }
    }
}
