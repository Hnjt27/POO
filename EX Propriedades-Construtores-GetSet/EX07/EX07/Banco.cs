using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EX07
{
    class Banco
    {

        public string Nome { get; set; }
        public int Nmrconta { get; private set; }
        public double Saldo { get; private set; }

        public Banco(string nome, int nmrconta)
        {
            Nome = nome;
            Nmrconta = nmrconta;
         
        }

        public Banco(string nome, int nmrconta, double saldo) : this(nome, nmrconta)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor){
            Saldo = Saldo + valor;
        }


        public void Saque(double valor)
        {
            Saldo =  Saldo - (valor + 5.0);
        }
      


        public override string ToString()
        {
            return " Conta: " 
                + Nmrconta 
                + "\n Titular: " 
                + Nome 
                + "\n Saldo Atual: " 
                + Saldo; 
        }
    }
}
