using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP3.Classes
{
    internal class Sphere
    {
        // Raio da esfera
        // Importante pois é um atributo que define a esfera
        // (4.0 / 3.0) * π * (raio * raio * raio)
        double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public void ShowRadius()
        {
            Console.WriteLine("Raio da esfera: " + radius);
        }

        public void CalculateVolume()
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("Volume da esfera: " + volume);
        }

        public void CalculateArea()
        {
            double area = 4 * Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Área da esfera: " + area);
        }
    }
}
