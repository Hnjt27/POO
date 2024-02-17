using LojadeInstrumentos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeInstrumentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Loja de instrumentos ");

            Console.WriteLine("Deseja cadastrar instrumentos ou clientes? (i/c) ");
            char escolha = char.Parse(Console.ReadLine());
            
            if ()



            Clientes cli = new Clientes("Carlos", "Rua das caralha", "4444-4444");

            loja.AddCliente(cli);
            loja.listarClientes();

            Console.ReadLine();
            
        }
 
    }
    
}
