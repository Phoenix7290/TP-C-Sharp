using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise11
    {
        public static void Run()
        {
            Console.WriteLine("Digite um número positivo para iniciar a contagem regressiva:");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                for (int i = 1; i <= 10; i++)
                {
                    int result = number * i;
                    Console.WriteLine($"{number} * {i} = {result}");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }
    }
}