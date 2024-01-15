
using EX01;

internal class Program
{
    public static void Main(string[] args)
    {
        Pessoa a = new Pessoa();
        Pessoa b = new Pessoa();

        Console.WriteLine("Digite o nome da primeira pessoa");
        a.Nome = Console.ReadLine();

        Console.WriteLine("Digite a idade da primeira pessoa");
        a.idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome da segunda pessoa");
        b.Nome = Console.ReadLine();

        Console.WriteLine("Digite a idade da segunda pessoa");
        b.idade = int.Parse(Console.ReadLine());


        if (a.idade > b.idade)
        {
            Console.WriteLine(" A pessoa " + a.Nome + " é mais velha, por que tem " + a.idade + " anos ");
        }
        else if (b.idade > a.idade)
        {
            Console.WriteLine(" A pessoa " + b.Nome + " é mais velha, por que tem " + b.idade + " anos ");
        }
        else
        {
            Console.WriteLine("Os dois tem a mesma idade");
        }

        Console.ReadLine();
    }
}