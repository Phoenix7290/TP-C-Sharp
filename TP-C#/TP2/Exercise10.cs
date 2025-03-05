using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise10
    {
        public static void Run ()
        {
            Console.WriteLine("Digite um número positivo para iniciar a contagem regressiva:");
            string? input = Console.ReadLine();

            if(int.TryParse(input, out int number) && number > 0)
            {
                while (number >= 0)
                {
                    Console.WriteLine(number);
                    number--;
                }
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }
    }
}
