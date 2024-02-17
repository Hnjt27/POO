using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeInstrumentos.Entities
{
    internal class Clientes
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }


        public Clientes(string nome, string endereco, string telefone) 
        { 
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public void ExibirDetalhes() 
        {
            Console.WriteLine("Nome: " + Nome + "Endereco: " + Endereco +
                     "Telefone: " + Telefone);
        }
    }
}
