using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("How many employees will be registered ?");
            int qtdEmp = int.Parse(Console.ReadLine());

            if (qtdEmp > 0)
            {
                for (int i = 0; i < qtdEmp; i++) 
                {

                    Console.WriteLine("Employee in register: " + i);

                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());
               

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                  

                    Console.Write("Salario: ");
                    double salario = double.Parse(Console.ReadLine());
                    
                    list.Add(new Employee (id, nome, salario));
                                        
                 
                    Console.WriteLine();    
                
                  
                }

                Console.WriteLine("Enter the employee id that will have salary increase:");
                int searchId = int.Parse(Console.ReadLine());   
                Employee emp  = list.Find(x => x.Id == searchId);

                if (emp != null)
                {
                    Console.WriteLine("Enter the porcentage");
                    double percent = double.Parse(Console.ReadLine());
                    emp.Percentage(percent);

                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Updated list of employees:");
                    foreach (object obj in list)
                    {
                        Console.WriteLine(obj);
                    }

                }
                else
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("this id (" + searchId + ") doesn't exists");

                    Console.WriteLine("Updated list of employees:");
                    foreach (object obj in list)
                    {
                        Console.WriteLine(obj);
                    }
                }
                                       
            }
            else 
            {
                Console.WriteLine("End program");
            }

            Console.ReadLine();
        }
    }
}
