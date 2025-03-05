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
            Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Data inválida. Por favor, insira uma data no formato dd/MM/yyyy.");
                return;
            }

            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataNascimento))
            {
                DateTime dataAtual = DateTime.Now;

                int idadeAnos = dataAtual.Year - dataNascimento.Year;
                int idadeMeses = dataAtual.Month - dataNascimento.Month;
                int idadeDias = dataAtual.Day - dataNascimento.Day;

                if (idadeMeses < 0)
                {
                    idadeAnos--;
                    idadeMeses += 12;
                }

                if (idadeDias < 0)
                {
                    idadeMeses--;
                    if (idadeMeses < 0)
                    {
                        idadeMeses += 12;
                        idadeAnos--;
                    }

                    DateTime ultimoMes = dataNascimento.AddMonths(idadeMeses);
                    idadeDias += (dataAtual - ultimoMes).Days;
                }

                Console.WriteLine($"Sua idade é: {idadeAnos} anos, {idadeMeses} meses e {idadeDias} dias.");
            }
            else
            {
                Console.WriteLine("Data inválida. Por favor, insira uma data no formato dd/MM/yyyy.");
            }
        }
    }
}