using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_C_.TP3.Classes;

namespace TP_C_.TP3
{
    internal class Exercise12
    {
        public static void Run()
        {
            Circle circle = new Circle(5.0);
            Sphere sphere = new Sphere(10.0);

            circle.ShowRadius();
            circle.CalculateArea();
            sphere.ShowRadius();
            sphere.CalculateVolume();
            sphere.CalculateArea();
        }
    }
}

