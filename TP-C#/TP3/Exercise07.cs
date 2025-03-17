using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_C_.TP3.Classes;

namespace TP_C_.TP3
{
    internal class Exercise07
    {
        public static void Run()
        {
            Enrollment enrollment = new Enrollment();
            enrollment.StudentName = "John Doe";
            enrollment.CourseName = "C#";
            enrollment.EnrollmentNumber = 1234;
            enrollment.Status = "Active";
            enrollment.initialDate = "01/01/2021";

            enrollment.ShowInfo();

        }
    }
}
