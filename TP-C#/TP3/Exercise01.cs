using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_C_.TP3.Classes;

namespace TP_C_.TP3
{
    internal class Exercise01
    {
        public static void Run()
        {
            // Classe é um modelo ou molde que define o comportamento do objeto.
            // Objeto é uma instância de uma classe.
            // Atributo é uma característica do objeto.
            // Método é uma ação que o objeto pode realizar.

            Person person = new Person("Rafael", 28);
            person.ShowInfo();
        }
    }
}
