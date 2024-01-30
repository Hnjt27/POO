using Ex014.Entities;
using Ex014.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the account data: ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = (Console.ReadLine());

            Console.Write("Initial balance: ");
            double blnc = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double wdraw = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, blnc, wdraw);

            Console.WriteLine("Enter the amount for withdraw: ");

            double amount = double.Parse(Console.ReadLine());

           
            try
            {

                account.Withdraw(amount);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine("Error" + e.Message);
            }


            Console.ReadLine();
        }
    }
}
