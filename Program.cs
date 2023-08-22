using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu ()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            
            Console.WriteLine("-----------------");

            short resposta = short.Parse(Console.ReadLine());

            switch(resposta) 
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma ()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valorUm = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valorDois = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float soma = valorUm+valorDois;
            Console.WriteLine($"O resultado da soma é {soma}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao () 
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valorUm = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valorDois = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float subtracao = valorUm-valorDois;
            Console.WriteLine($"O resultado da subtração é {subtracao}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao ()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valorUm = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valorDois = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float multiplicacao = valorUm*valorDois;
            Console.WriteLine($"O resultado da multiplicação é {multiplicacao}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao ()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valorUm = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valorDois = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float divisao = valorUm/valorDois;
            Console.WriteLine($"O resultado da divisão é {divisao}");
            Console.ReadKey();
            Menu();
        }
    }
}