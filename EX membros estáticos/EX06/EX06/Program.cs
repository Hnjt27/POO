using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Digite abaixo o valor que deseja comprar em dolares");
                double qtdcompra = double.Parse(Console.ReadLine());

                Conversordemoeda.conversao(qtdcompra);

                Console.WriteLine("A quantidade em reais que você irá pagar é de " + Conversordemoeda.reais);
                          
                Console.ReadLine();

        }
    }
}
