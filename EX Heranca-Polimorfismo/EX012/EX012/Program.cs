using EX012.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;



namespace EX012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int numProd  = int.Parse(Console.ReadLine());

            for (int i = 0; i < numProd; i++)
            {
                Console.WriteLine($"Product #{i} data: ");

                Console.WriteLine("Common, used or imported ? (c/u/i)");
                char prodStatus = char.Parse(Console.ReadLine());

                switch (prodStatus.ToString()) {
                    case "c":
                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Product(name, price));

                        break;
                    case "u":

                        Console.Write("Name: ");
                        string nameu = Console.ReadLine();

                        Console.Write("Price: ");
                        double priceu = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Manufactured Date (DD/MM/YYYY)");
                        DateTime manuDate = DateTime.Parse(Console.ReadLine());

                        list.Add(new UsedProduct(nameu, priceu, manuDate));

                        break;
                    case "i":
                        Console.Write("Name: ");
                        string namei = Console.ReadLine();

                        Console.Write("Price: ");
                        double pricei = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Customs Fee: ");
                        double customfee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                        list.Add(new ImportedProduct(namei, pricei, customfee));

                        break;
                    default:
                        Console.WriteLine("You choose a wrong option ");
                        break;
                }

            }

            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());            
            }
                

            Console.ReadLine();
        }
    }
}

