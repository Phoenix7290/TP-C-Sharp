using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise08
    {
        public static void Run()
        {
            Console.Write("Digite uma nota de 0 a 10: ");
            if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0 && grade <= 10)
            {
                // Interessante forma de usar switch case com expressões
                string classification = grade switch
                {
                    < 5 => "Insuficiente",
                    < 7 => "Regular",
                    < 9 => "Bom",
                    _ => "Excelente"
                };

                Console.WriteLine($"A classificação da nota é: {classification}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira uma nota válida entre 0 e 10.");
            }
        }
    }
}
