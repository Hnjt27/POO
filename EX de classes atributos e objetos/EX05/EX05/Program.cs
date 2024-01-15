using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.WriteLine("digite o nome do aluno:");
            a.nome = Console.ReadLine();

            Console.WriteLine("Digite as notas do aluno " + a.nome);

            Console.Write("Nota 1: ");
            a.nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            a.nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            a.nota3 = double.Parse(Console.ReadLine());


            double m = a.CalcMedia();
            double r = a.Res();

            if (m >= 60)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("A nota final de " + a.nome + " é: " + m);
                
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("A nota final de " + a.nome + " é: " + m);
                Console.WriteLine("Faltaram " +  r + " pontos");
            }

            Console.ReadLine();
        }   
    }
}
