using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_C_.TP3.Classes;

namespace TP_C_.TP3
{
    internal class Exercise09
    {
        public static void Run()
        {
            Enrollment enrollment = new Enrollment();
            enrollment.StudentName = "Robin";
            enrollment.CourseName = "C Sharp";
            enrollment.EnrollmentNumber = 4321;
            enrollment.Status = "Active";
            enrollment.initialDate = "01/01/2025";

            enrollment.suspendEnrollment();
            enrollment.ShowInfo();
            enrollment.activateEnrollment();
            enrollment.ShowInfo();
        }
    }
}
