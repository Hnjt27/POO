using EX_013.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_013
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Individual individual = new Individual("Victor", 50000, 2000);

            Company comp = new Company("Victor", 400000, 25);

            comp.Tax();
            individual.Tax();

            Console.WriteLine(individual+ " - " + comp);
            Console.ReadLine();

        }
    }
}
