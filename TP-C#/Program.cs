using System;

namespace TP_C_
{
    class Program
    {
        static void Main()
        {
            string? tpChoice = GetUserInput("Escolha o TP (1, 2 ou 3):");
            if (tpChoice == null)
            {
                Console.WriteLine("Escolha de TP inválida.");
                return;
            }

            switch (tpChoice)
            {
                case "1":
                    ExecuteTP1();
                    break;
                case "2":
                    ExecuteTP2();
                    break;
                case "3":
                    ExecuteTP3();
                    break;
                default:
                    Console.WriteLine("Escolha de TP inválida.");
                    break;
            }
        }

        static string? GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static void ExecuteTP1()
        {
            Console.WriteLine("Executando TP1:");
            TP1.Exercises.Run();
        }

        static void ExecuteTP2()
        {
            string? exerciseChoice = GetUserInput("Escolha o Exercício (1-12):");
            if (exerciseChoice == null)
            {
                Console.WriteLine("Escolha de exercício inválida.");
                return;
            }

            switch (exerciseChoice)
            {
                case "1":
                    TP2.Exercise01.Run();
                    break;
                case "2":
                    TP2.Exercise02.Run();
                    break;
                case "3":
                    TP2.Exercise03.Run();
                    break;
                case "4":
                    TP2.Exercise04.Run();
                    break;
                case "5":
                    TP2.Exercise05.Run();
                    break;
                case "6":
                    TP2.Exercise06.Run();
                    break;
                case "7":
                    TP2.Exercise07.Run();
                    break;
                case "8":
                    TP2.Exercise08.Run();
                    break;
                case "9":
                    TP2.Exercise09.Run();
                    break;
                case "10":
                    TP2.Exercise10.Run();
                    break;
                case "11":
                    TP2.Exercise11.Run();
                    break;
                case "12":
                    TP2.Exercise12.Run();
                    break;
                default:
                    Console.WriteLine("Escolha de exercício inválida.");
                    break;
            }
        }

        static void ExecuteTP3()
        {
            string? exerciseChoice = GetUserInput("Escolha o Exercício (1-12):");
            if (exerciseChoice == null)
            {
                Console.WriteLine("Escolha de exercício inválida.");
                return;
            }

            switch (exerciseChoice)
            {
                case "1":
                    TP3.Exercise01.Run();
                    break;
                case "2":
                    TP3.Exercise02.Run();
                    break;
                case "3":
                    TP3.Exercise03.Run();
                    break;
                case "4":
                    TP3.Exercise04.Run();
                    break;
                case "5":
                    TP3.Exercise05.Run();
                    break;
                case "6":
                    TP3.Exercise06.Run();
                    break;
                case "7":
                    TP3.Exercise07.Run();
                    break;
                case "8":
                    TP3.Exercise08.Run();
                    break;
                case "9":
                    TP3.Exercise09.Run();
                    break;
                case "10":
                    TP3.Exercise10.Run();
                    break;
                case "11":
                    TP3.Exercise11.Run();
                    break;
                case "12":
                    TP3.Exercise12.Run();
                    break;
                default:
                    Console.WriteLine("Escolha de exercício inválida.");
                    break;
            }
        }
    }
}