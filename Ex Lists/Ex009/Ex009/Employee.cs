using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex009
{
    internal class Employee
    {
        public int Id { get; private set; }

        public string Nome { get; set; }

        public double Salario { get; set; }



        public Employee(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Salario = 0;
        }

        public Employee(int id, string nome, double salario) : this (id, nome) {
            Salario = salario;
        }


        public void Percentage(double percentage)
        {
            Salario = (percentage * Salario / 100) + Salario;
        }


        public override string ToString()
        {
            return "Id: " + Id + "\nNome: " + Nome + "\nSalário: " + Salario; 
        }

    }



}
