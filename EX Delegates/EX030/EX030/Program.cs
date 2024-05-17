using EX030.Services;

namespace EX030
{
    delegate double BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Digite o valor 1:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2:");
            double y = double.Parse(Console.ReadLine());

            BinaryNumericOperation op = CalculationServices.Sum;

            double result = op(x, y);
            Console.WriteLine(result);
         






        }
    }
}
