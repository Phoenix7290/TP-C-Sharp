using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise12
    {
        public static void Run()
        {
            Console.WriteLine("Advinhe um número entre 1 até 100.");
            string? guess = Console.ReadLine();

            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            if (int.TryParse(guess, out int number))
            {
                while (number != randomNumber)
                {
                    if (number > randomNumber)
                    {
                        Console.WriteLine("O número é menor.");
                    }
                    else
                    {
                        Console.WriteLine("O número é maior.");
                    }
                    Console.WriteLine("Tente novamente:");
                    guess = Console.ReadLine();
                    if (int.TryParse(guess, out number))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um número válido.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }

            Console.WriteLine("Parabéns! O número randomizado foi: " + randomNumber);
        }
    }
}