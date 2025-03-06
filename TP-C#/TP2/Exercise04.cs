using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP2
{
    internal class Exercise04
    {
        public static void Run()
        {
            Console.Write("Digite seu nome: ");
            string? name = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int age = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite seu número de telefone: ");
            string? phone = Console.ReadLine();

            Console.Write("Digite seu email: ");
            string? email = Console.ReadLine();

            Console.WriteLine("\nRegistro realizado com sucesso!\n");
            Console.WriteLine("Data registrada:");
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Idade: {age} anos");
            Console.WriteLine($"Telefone: {phone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}