using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise09
    {
        public static void Run()
        {
            Console.Write("Digite o salário bruto: ");
            if (double.TryParse(Console.ReadLine(), out double grossSalary))
            {
                double taxRate;
                if (grossSalary <= 2000)
                {
                    taxRate = 0.0;
                }
                else if (grossSalary <= 3000)
                {
                    taxRate = 0.08;
                }
                else if (grossSalary <= 4500)
                {
                    taxRate = 0.18;
                }
                else
                {
                    taxRate = 0.28;
                }

                double taxAmount = grossSalary * taxRate;
                double netSalary = grossSalary - taxAmount;

                Console.WriteLine($"Salário Bruto: {grossSalary:C2}");
                Console.WriteLine($"Descontos: {taxAmount:C2}");
                Console.WriteLine($"Salário Líquido: {netSalary:C2}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um valor numérico válido.");
            }
        }
    }
}
