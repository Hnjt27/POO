using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário");
            f.nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionário");
            f.salariobruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do imposto ");
            f.imposto = double.Parse(Console.ReadLine());


            f.SalarioLiquido();

            Console.WriteLine(f);

            Console.WriteLine("deseja aumentar o salário em quantos % ? ");


            double prcntgm = double.Parse(Console.ReadLine());

            
            f.aumentarSalario(prcntgm);


            Console.WriteLine(f);


            Console.ReadLine();

        }
    }
}
