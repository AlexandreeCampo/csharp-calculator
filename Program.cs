using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); //Aqui fazemos a chamada dos métodos.
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
                default: Menu(); break; // default sempre irá chamar o Menu quando escolhermos uma opção que não existe.
            }
        }

        static void Soma () // Método para Somar os valores
        {
            Console.Clear(); // Clear ira limpar a tela antes que algo ser executado.

            Console.WriteLine("Primeiro valor: "); // Dando entrada de um valor
            float valorUm = float.Parse(Console.ReadLine()); // ReadLine vai ler este valor e armazenar na variável valorUm. Parse converte string em float

            Console.WriteLine("Segundo valor: ");
            float valorDois = float.Parse(Console.ReadLine());

            Console.WriteLine(""); // Pulando uma linha.

            float soma = valorUm+valorDois;
            Console.WriteLine($"O resultado da soma é {soma}"); //Estou usando o format que é o cifrão $ fora das aspas a esquerda, junto das chaves que envolvem a variável.
            Console.ReadKey(); // ReadKey faz com que o programa não termine na chamada do primeiro método, assim podendo fazer a chamada do restante.
            Menu();
        }

        static void Subtracao () 
        {
            Console.Clear(); // Clear ira limpar a tela antes que algo ser executado.

            Console.WriteLine("Primeiro valor: "); // Dando entrada de um valor
            float valorUm = float.Parse(Console.ReadLine()); // ReadLine vai ler este valor e armazenar em v1. Parse converte string em float

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