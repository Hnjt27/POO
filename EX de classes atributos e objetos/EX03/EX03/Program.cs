using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Digite as informações do retangulo para os calculos");

            Console.Write("Digite a altura: ");
            r.altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a largura: ");
            r.largura = double.Parse(Console.ReadLine());

            Console.WriteLine(r);


            Console.ReadLine();

        }
    }
}
