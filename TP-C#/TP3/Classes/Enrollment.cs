using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP3.Classes
{
    public class Enrollment
    {
        public String StudentName { get; set; }
        public String CourseName { get; set; }
        public int EnrollmentNumber { get; set; }
        public String Status { get; set; }
        public String initialDate { get; set; }

        public void suspendEnrollment()
        {
            Status = "Trancada";
        }

        public void activateEnrollment()
        {
            Status = "Ativa";
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Nome do aluno: {StudentName}, Nome do curso: {CourseName}, Número de matrícula: {EnrollmentNumber}, Status: {Status}, Data de início: {initialDate}");
        }
    }
}
