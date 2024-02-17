using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using EX_015.Entities;
using EX_015.Services;

namespace EX_015
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Contract Data");
            Console.Write("Number: ");
            int nmbContract = int.Parse(Console.ReadLine());
            
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            Console.Write("Contract Value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract mycontract = new Contract(nmbContract, date, totalValue);

            Console.Write("Enter the number of installments: ");
            int nmbInstallments = int.Parse(Console.ReadLine());

            ContractServices contractService = new ContractServices(new PaypalService());
            contractService.ProccesContract(mycontract, nmbInstallments);

            foreach (Installments installments in mycontract.Installments)
            {
                Console.WriteLine(installments);
            }

            Console.ReadLine();
        }
    }
}
