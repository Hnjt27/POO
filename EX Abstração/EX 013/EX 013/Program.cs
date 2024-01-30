using EX_013.Entities;
using System;
using System.Collections.Generic;
using System.Globalization; 

namespace EX_013
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payer:");

            int nmbTPayer =  int.Parse(Console.ReadLine());

            for (int i = 1; i-1 < nmbTPayer; i++) 
            { 
                Console.WriteLine($"Tax payer #{i} data");

                Console.Write("Individual or company ? (i/c): ");
                char ic = char.Parse(Console.ReadLine());

                switch (ic) { 
                    case 'i':
                        Console.WriteLine();
                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Anual income: ");
                        double anualInc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Health expenditures: ");
                        double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Individual ind = new Individual(name, anualInc, healthExp);

                        list.Add(ind);

                        break;

                    case 'c':
                        Console.WriteLine();
                        Console.Write("Name: ");
                        string nameI = Console.ReadLine();

                        Console.Write("Anual income: ");
                        double anualIncI = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Number of employees: ");
                        int nmbEmployee = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Company comp = new Company(nameI, anualIncI, nmbEmployee);

                        list.Add(comp);

                        break;
  
                    default: Console.WriteLine("you choose a inexisting option");
                            break;

                }

            }

            Console.WriteLine();
            Console.WriteLine("Total taxes: ");
            double sum = 0;

            foreach (TaxPayer tax in list)
            {
               
                Console.WriteLine(tax.Name +" "+ tax.ToString());
                sum += tax.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("Total taxes: ");
            Console.WriteLine(sum.ToString());



            Console.ReadLine();
        }
    }
}
