using System;


namespace EX07
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco conta;

            Console.WriteLine("Olá seja bem vindo ao Banco PUSSYBANK");
            Console.Write("Informe seu nome: ");
            string titular = Console.ReadLine();

            Console.Write("Informe o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Haverá depósito inicial (s/n) ?");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o saldo da conta:");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Banco(titular, numeroConta, depositoInicial);
                Console.WriteLine(conta);
            }
            else if (resp == 'n' || resp == 'N')
            {
               conta = new Banco(titular, numeroConta);
                Console.WriteLine(conta);
            }
            else {
                Console.WriteLine("O valor digitado é invalido no sistema");
            }

            
        
        

            Console.WriteLine("Digite agora um valor para depósito");
            double quantia = double.Parse(Console.ReadLine());
         
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);

            Console.WriteLine("Digite agora um valor para saque");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizado");
            Console.WriteLine(conta);

            Console.ReadLine();

        }
    }
}
