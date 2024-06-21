using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {

            MeuMetodo();

            string nome = RetornaNome("Vitor","Gomes",25);
            System.Console.WriteLine(nome);
        }
        static void MeuMetodo()
        {
            Console.WriteLine("C# é maneiro");
        }

        static string RetornaNome(string nome, string sobrenome, int idade = 0)
        {
            return $"{nome} {sobrenome} {idade.ToString()}";
        }
    }
}