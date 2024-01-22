using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;
using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

      
            DateTime moment = DateTime.Now;

            //Area para cadastro do cliente
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Date of birth: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            DateTime birthdate = birth.Date;

            Client client = new Client(name,email,birthdate);

            Console.WriteLine("");
            Console.WriteLine("Enter order data");
            Console.Write("Status (Delivered/PendingPayment/Processing/Shipped): ");
                     
            OrderStatus statusenum = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Order order = new Order(moment, statusenum, client);

            Console.WriteLine("");

            Console.Write("How many items to this order: ");
                       
            int n = int.Parse(Console.ReadLine());

                      
            for (int i = 1; i-1 < n; i++) 
            { 
                Console.WriteLine($"Enter #{i} item data");

                Console.Write("Product name: ");
                string prodName = Console.ReadLine();

                Console.Write("Product Price: ");
                double prodPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity of product: ");
                int orditmQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);    

                OrderItem orderItem = new OrderItem(orditmQuantity, prodPrice, product);

         

                order.AddItem(orderItem);

            }

            Console.WriteLine("");

            moment = DateTime.Now;
         
            Console.WriteLine(order);
      
            Console.ReadLine();

        }
    }
}
