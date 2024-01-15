using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex008Certo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a;
            Console.Write("Quantos quartos serão alugados? :");
            int qtdQuartos = int.Parse(Console.ReadLine());
            int quarto;
            Aluno[] vect = new Aluno[10];

            if (qtdQuartos > 0)
            {
                for (int i = 0; i < qtdQuartos; i++)
                {
                    
                    Console.WriteLine("Digite as informações do quarto: " + (i = i++));
                  
                 
                    Console.WriteLine("Digite o numero do quarto desejado:");
                    quarto = int.Parse(Console.ReadLine());
                      
                    
                    Console.Write("Digite o nome do aluno que irá se hospedar: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o email do aluno: ");
                    string email = Console.ReadLine();

                
                    vect[quarto] = a = new Aluno(nome, email);

         
                }

                for (int i = 0; i < 10; i++)
                {
                    if (vect[i] != null)
                    {
                        Console.WriteLine(i + ":" + vect[i]);
                    }

                }

            }

         


            Console.ReadLine();
        
        }
            
  
    }
}
