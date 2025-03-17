using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise03
    {
        public static void Run()
        {
            Console.Write("Digite sua data de nascimento (dia/mês/ano): ");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Data inválida. Por favor, insira uma data no formato dia/mês/ano.");
                return;
            }

            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthDate))
            {
                DateTime now = DateTime.Now;

                
            }
            else
            {
                Console.WriteLine("Data inválida. Por favor, insira uma data no formato dia/mês/ano.");
            }
        }
    }
}