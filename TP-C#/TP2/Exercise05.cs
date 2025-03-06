using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise05
    {
        static (double, double) ConvertTemperature(double celsius)
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            double kelvin = celsius + 273.15;
            return (fahrenheit, kelvin);
        }

        public static void Run()
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double celsius))
            {
                var (fahrenheit, kelvin) = ConvertTemperature(celsius);

                Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit:F2}°F");
                Console.WriteLine($"A temperatura em Kelvin é: {kelvin:F2}K");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            }
        }
    }
}
