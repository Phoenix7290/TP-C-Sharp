using System;

namespace TP_C_.TP1
{
    internal class Exercises
    {
        public static void Run()
        {
            // Exercise 5
            Console.WriteLine("Hello, World!");

            // Exercise 7
            Console.WriteLine("Algum Erro existiu aqui.");
            int[] numeros = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numeros[i] = i;
                Console.WriteLine(numeros[i]);
            }

            // Exercise 8
            Console.WriteLine("Qual seu nome?");
            string? inputName = Console.ReadLine();
            if (inputName != null)
            {
                Console.WriteLine("Olá, " + inputName);
            }
            else
            {
                Console.WriteLine("Nome não fornecido.");
            }

            // Exercise 9
            int age = 18;
            double height = 1.75;
            string anotherName = "Rafael";
            Console.WriteLine("Nome: " + anotherName + ", Idade: " + age + ", Altura: " + height);

            // Exercise 10
            string nullName;
            int nullAge;
            nullName = "Marcos";
            nullAge = 18;
            Console.WriteLine("Nome: " + nullName + ", Idade: " + nullAge);
        }
    }
}