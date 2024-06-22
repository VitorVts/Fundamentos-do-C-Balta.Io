using System;

namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("-------Calculadora-------");
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("Qual operção deseja :\n1 - Soma\n2 - Subtração \n3 - Divisão\n4 - Multiplicação\n5 - Sair");
            System.Console.WriteLine("------------------");
            Console.Write("Selecione uma opção : ");
            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            System.Console.WriteLine("------SOMA------");
            System.Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            System.Console.WriteLine($"\nO Resultado da Soma é {resultado}!\n");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            System.Console.WriteLine("------SUBTRAÇÃO------");
            System.Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Primeiro Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1-v2;

            System.Console.WriteLine($"\nO Resultado da Subtração é {resultado}"); 
            Console.ReadKey();
            Menu();

        }
        static void Divisao()
        {
            Console.Clear();
            System.Console.WriteLine("------DIVISÃO------");
            System.Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1/v2;

            System.Console.WriteLine($"O Resultado da Divisão é : {resultado}");
            
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            System.Console.WriteLine("------MULTIPLICAÇÃO------");
            System.Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1*v2;

            System.Console.WriteLine($"O Resultado da Multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Sair()
        {
            Console.Clear();
            System.Console.WriteLine("\nObrigado Por Utilizar a Calculadora!\n");
            System.Environment.Exit(0);
        }
    }
}