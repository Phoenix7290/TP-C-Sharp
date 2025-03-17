using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP3.Classes
{
    internal class Circle
    {
        // Raio do círculo
        // Importante pois é um atributo que define o círculo
        // π * (raio * raio)
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void ShowRadius()
        {
            Console.WriteLine("Raio do círculo: " + radius);
        }

        public void CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Área do círculo: " + area);
        }
    }
}
