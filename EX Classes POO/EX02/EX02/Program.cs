using EX02;


 public class Program
{
   static void Main(string[] args)
    {
        Assalariado a = new Assalariado();
        Assalariado b = new Assalariado();
        double media = 0;

        Console.WriteLine("Digite o nome do primeiro funcionario");
        a.nome = Console.ReadLine();

        Console.WriteLine("Digite o salario do primeiro funcionario");
        a.salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do segundo funcionario");
        b.nome = Console.ReadLine();

        Console.WriteLine("Digite o salario do segundo funcionario");
        b.salario = double.Parse(Console.ReadLine());

        media = (a.salario + b.salario) / 2.0;

        Console.WriteLine("A média do salario dos cabloco é de " + media);

        Console.ReadLine();

    }
}