using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMedia1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de numeros que deseja calcular a média: ");
            int qtdNmb = int.Parse(Console.ReadLine());

            int[] vect = new int [qtdNmb];
       
            for (int i = 0; i < qtdNmb; i++) 
            {
                Console.Write($"{i+1}° Numero: ");
                int value = int.Parse(Console.ReadLine());

                vect[i] = value;
                
            }



            int sum = 0;
            foreach (int i in vect) 
            {
                sum += i;
            }

            double media = sum / qtdNmb;

            Console.WriteLine("Sua soma é: " + sum);
            Console.WriteLine("Sua média é: " + media);

            Console.ReadLine();
        }
    }
}
