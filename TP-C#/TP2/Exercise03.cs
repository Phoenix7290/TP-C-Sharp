using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise01
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

                int years = now.Year - birthDate.Year;
                int months = now.Month - birthDate.Month;
                int days = now.Day - birthDate.Day;

                if (days < 0)
                {
                    months--;
                    days += DateTime.DaysInMonth(now.Year, now.Month - 1);
                }

                if (months < 0)
                {
                    years--;
                    months += 12;
                }

                Console.WriteLine($"Sua idade é: {years} anos, {months} meses e {days} dias.");
            }
            else
            {
                Console.WriteLine("Data inválida. Por favor, insira uma data no formato dia/mês/ano.");
            }
        }
    }
}