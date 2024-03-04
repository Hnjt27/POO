using EX0018b.Entities;

namespace EX0018b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<AlumnCode> set = new HashSet<AlumnCode>();
            AlumnCode alu;


            Console.Write("How many studants for course A: ");
            int qtdA = int.Parse(Console.ReadLine());
            Console.WriteLine($"Type the {qtdA} alumn codes");

            for (int i = 0; i < qtdA; i++) 
            {
                int code = int.Parse(Console.ReadLine());
                alu = new AlumnCode(code);
                set.Add(alu);                        
            }


            Console.Write("How many studants for course B: ");
            int qtdB = int.Parse(Console.ReadLine());
            Console.WriteLine($"Type the {qtdB} alumn codes");

            for (int i = 0; i < qtdB; i++)
            {
                int code = int.Parse(Console.ReadLine());
                alu = new AlumnCode(code);
                set.Add(alu);

            }

            Console.Write("How many studants for course C: ");
            int qtdC = int.Parse(Console.ReadLine());
            Console.WriteLine($"Type the {qtdC} alumn codes");
            for (int i = 0; i < qtdC; i++)
            {
                int code = int.Parse(Console.ReadLine());
                alu = new AlumnCode(code);
                set.Add(alu);

            }

            Console.WriteLine("Total users: "+ set.Count);


        }
    }
}
