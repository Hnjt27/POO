using ConsoleApp1.Entities.Enums;
using System;
using System.Collections.Generic;

using System.Text;


namespace ConsoleApp1.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        List<OrderItem> Items { get; set;} = new List<OrderItem>();
        public Client Client { get; set; }
    
   
        public Order() 
        { 
        
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
           
        }

        public void AddItem(OrderItem item) {

            Items.Add(item);

        }

        public void RemoveItem(OrderItem item)
        {

            Items.Remove(item);

        }
   

        public double Total() 
        {

            double sum = 0.0;

            foreach (OrderItem item in Items)
            { 
                sum = sum + item.SubTotal();
              
            }

            return sum;
           
        }



      
  
        public override string ToString()
        {

            StringBuilder sbb = new StringBuilder();

            sbb.Append("Order moment: ");
            sbb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));

            sbb.Append("Order status: ");
            sbb.AppendLine(Status.ToString());

            sbb.Append("Order client: ");
            sbb.AppendLine(Client.ToString());

            sbb.AppendLine("\nOrder items");

            foreach (OrderItem item in Items) 
            {
                sbb.AppendLine(item.ToString());
            }

            sbb.AppendLine("Total price: " + Total().ToString());

            return sbb.ToString();

          
        }

    }

   
}
