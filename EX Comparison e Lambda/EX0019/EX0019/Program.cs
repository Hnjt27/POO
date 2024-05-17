using EX0019.Entities;
using System.Globalization;

namespace EX0019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Product prod;
            Console.WriteLine("How many items do you want in list? ");
            int qtd = int.Parse(Console.ReadLine());
            
            for (int i = 0; i<qtd; i++) 
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                prod = new Product(name, price);
                list.Add(prod);
            }

            //Expressão lambda
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.Sort(comp);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //static int CompareProduct(Product p1, Product p2)
        //{ 
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}
