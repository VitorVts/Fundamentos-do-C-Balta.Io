using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Glaive", 299.50,EProductType.Product);

            var manutencaoEletrica =  new Product(2,"manutenção eletrica",500, EProductType.Service);
            mouse.Id = 55;

            System.Console.WriteLine(mouse.Id);
            System.Console.WriteLine(mouse.Name);
            System.Console.WriteLine(mouse.Price);

            System.Console.WriteLine((int)manutencaoEletrica.Type);
        }
    }

    struct Product
    {

        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        
        public EProductType Type;

        public double PriceInDolar(double dolar){
            return dolar * Price;
        }
    }

    enum EProductType 
    {
        Product =1,
        Service =2
    }
}