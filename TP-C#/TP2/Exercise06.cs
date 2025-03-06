using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise06
    {
        public static void Run()
        {
            Console.Write("Digite seu peso em (kg):");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura em (m):");
            double height = Convert.ToDouble(Console.ReadLine(), new CultureInfo("en-US"));

            double imc = weight / (height * height);


            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc < 35)
            {
                Console.WriteLine("Obesidade grau 1");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade grau 2");
            }
            else
            {
                Console.WriteLine("Obesidade grau 3");
            }
        }
    }
}
