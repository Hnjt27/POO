using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04
{
    internal class Funcionario
    {
        public string nome = "";
        public double salariobruto;
        public double imposto;



        public double SalarioLiquido()
        {
            return salariobruto - imposto;

        }

        public void aumentarSalario(double porcentagem) {
            
        
            salariobruto = salariobruto + (porcentagem / 100) * salariobruto;

            

            SalarioLiquido();

        }

        public override string ToString()
        {
            return "Dados atualizados: " + nome + " " + SalarioLiquido();
        }
    }
}
