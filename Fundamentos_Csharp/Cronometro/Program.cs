using System;
using System.Threading;

namespace StopWatch
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos\nM = Minuto => 1m = 1 minuto\n0 - Sair\nQuanto tempo deseja contar ? ");
            
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0,data.Length-1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            if (time == 0)
                System.Environment.Exit(0);
            PreStart(time*multiplier);

        }
        static void PreStart(int time)
        {
            Console.Clear();
            System.Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Set...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start(int time )
        {
            
            int currenTime = 0;

            while(currenTime!=time)
            {
                Console.Clear();
                currenTime++;
                System.Console.WriteLine(currenTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            System.Console.WriteLine("StopWatch Finalizado");
            Thread.Sleep(2500);
        }
    }
}