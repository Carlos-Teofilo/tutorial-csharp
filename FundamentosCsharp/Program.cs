using SearchAlgorithms.SequentialSearch;
using System;

namespace FundamentosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product(1, "Keybord", 199.99, EProductType.Product);
            Console.WriteLine(p.Type);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("Nao retorna nada");
        }

        static string Greeting()
        {
            return "Hello, World";
        }
    }

    struct Product
    {
    public int Id {get;}
    public string Title;
    public double Price;
    public EProductType Type;

    public Product(
        int id, string title, double price, EProductType type
        )
        {
            Id = id;
            Title = title;
            Price = price;
            Type = type;
        }
    
    public double PriceInDolar(double dolar = 5.6)
        {
            return Price * dolar;
        }

    }
    
    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}